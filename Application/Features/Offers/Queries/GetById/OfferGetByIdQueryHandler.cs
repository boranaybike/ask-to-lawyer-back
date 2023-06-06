using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Offers.Queries.GetById
{
    public class OfferGetByIdQueryHandler : IRequestHandler<OfferGetByIdQuery, OfferGetByIdDto>
    {
        private readonly IApplicationDbContext _context;

        public OfferGetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OfferGetByIdDto> Handle(OfferGetByIdQuery request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers.FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);

            if (offer == null)
                return null;

            var offerDto = new OfferGetByIdDto
            {
                Id = offer.Id,
                LawyerId = offer.LawyerId,
                QuestionId = offer.QuestionId,
                Price = offer.Price,
                IsAccepted = offer.IsAccepted,
                AcceptDate = offer.AcceptDate
            };

            return offerDto;
        }
    }
}
