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
                    ClientId = a.ClientId,
                    LawyerId = a.LawyerId,
                    MessageBody = a.MessageBody,
                    OfferId = a.OfferId,
                    FromClient = a.FromClient,
                    FromLawyer = a.FromLawyer
                })
                .ToArrayAsync(cancellationToken);

            return answers;
        }
    }
}
