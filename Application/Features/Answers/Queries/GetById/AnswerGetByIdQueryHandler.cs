using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Answers.Queries.GetById
{
    public class AnswerGetByIdQueryHandler : IRequestHandler<AnswerGetByIdQuery, AnswerGetByIdDto>
    {
        private readonly IApplicationDbContext _context;

        public AnswerGetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AnswerGetByIdDto> Handle(AnswerGetByIdQuery request, CancellationToken cancellationToken)
        {
            var answer = await _context.Answers
                .Where(a => a.Id == request.Id)
                .Select(a => new AnswerGetByIdDto
                {
                    Id = a.Id,
                    ClientId = a.ClientId,
                    LawyerId = a.LawyerId,
                    MessageBody = a.MessageBody,
                    OfferId = a.OfferId,
                    FromClient = a.FromClient,
                    FromLawyer = a.FromLawyer
                })
                .FirstOrDefaultAsync(cancellationToken);

            return answer;
        }
    }
}
