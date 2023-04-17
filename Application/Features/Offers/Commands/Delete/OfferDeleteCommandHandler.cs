using Application.Common.Interfaces;
using Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Application.Features.Offers.Commands.Delete
{
    public class OfferDeleteCommandHandler : IRequestHandler<OfferDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public OfferDeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Response<int>> Handle(OfferDeleteCommand request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            ;

            if (offer is null)
            {
                throw new ArgumentException();
            }

            _context.Offers.Remove(offer);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"successfully deleted.", offer.Id);
        }
    }
}
