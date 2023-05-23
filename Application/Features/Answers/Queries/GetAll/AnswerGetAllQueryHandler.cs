using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Answers.Queries.GetAll
{
    public class AnswerGetAllQueryHandler : IRequestHandler<AnswerGetAllQuery, AnswerGetAllDto[]>
    {
        private readonly IApplicationDbContext _context;

        public AnswerGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AnswerGetAllDto[]> Handle(AnswerGetAllQuery request, CancellationToken cancellationToken)
        {
            var answers = await _context.Answers
                .Select(a => new AnswerGetAllDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Date = a.Date,
                    OfferAcceptDate = a.OfferAcceptDate,
                    OfferId = a.OfferId
                })
                .ToArrayAsync(cancellationToken);

            return answers;
        }
    }
}
