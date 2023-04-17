using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Offers.Commands.Add
{
    public class OfferAddCommandHandler : IRequestHandler<OfferAddCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;
        public OfferAddCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Response<int>> Handle(OfferAddCommand request, CancellationToken cancellationToken)
        {
            var offer = new Offer
            {
                LawyerId = request.LawyerId,
                AnswerId = request.AnswerId,
                QuestionId = request.QuestionId,
                Price = request.Price,
                AcceptDate = DateTimeOffset.Now,
                IsDeleted = false,
                CreatedOn = DateTimeOffset.Now,
                CreatedByUserId = null,
            };
            
            await _context.Offers.AddAsync(offer, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"offer succesfully added", offer.Id);
        }
    }
}
