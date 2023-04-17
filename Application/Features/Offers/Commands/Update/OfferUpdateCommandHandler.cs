using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Offers.Commands.Update
{
    public class OfferUpdateCommandHandler : IRequestHandler<OfferUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;
        public OfferUpdateCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(OfferUpdateCommand request, CancellationToken cancellationToken)
        {
            var offer = _context.Offers.FirstOrDefault(x => x.Id == request.Id);
            offer.Price = request.Price;
            offer.IsAccepted = request.IsAccepted;
            await _context.SaveChangesAsync(cancellationToken);
            return new Response<int>($"offer successfully updated.", offer.Id);
        }
    }
}
