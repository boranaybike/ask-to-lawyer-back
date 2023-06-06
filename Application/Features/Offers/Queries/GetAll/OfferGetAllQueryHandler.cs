using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Offers.Queries.GetAll
{
    public class OfferGetAllQueryHandler : IRequestHandler<OfferGetAllQuery, List<OfferGetAllDto>>
    {
        private readonly IApplicationDbContext _context;

        public OfferGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<OfferGetAllDto>> Handle(OfferGetAllQuery istek, CancellationToken cancellationToken)
        {
            var teklifler = await _context.Offers.ToListAsync(cancellationToken);

            var OfferDtoList = teklifler.Select(o => new OfferGetAllDto
            {
                Id = o.Id,
                LawyerId = o.LawyerId,
                QuestionId = o.QuestionId,
                Price = o.Price,
                IsAccepted = o.IsAccepted,
                AcceptDate = o.AcceptDate
            }).ToList();

            return OfferDtoList;
        }
    }
}
