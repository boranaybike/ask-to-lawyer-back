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
            var teklifler = await _context.Offers.Include(o => o.Lawyer).ToListAsync(cancellationToken);

            var OfferDtoList = teklifler.Select(o => new OfferGetAllDto
            {
                Id = o.Id,
                LawyerId = o.LawyerId,
                QuestionId = o.QuestionId,
                Price = o.Price,
                IsAccepted = o.IsAccepted,
                LawyerFirstName = o.Lawyer?.FirstName,
                LawyerLastName = o.Lawyer?.LastName,
                LawyerBar = o.Lawyer?.Bar

            }).ToList();

            return OfferDtoList;
        }
    }
}
