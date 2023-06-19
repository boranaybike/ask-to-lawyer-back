using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Answers.Commands.Add
{
    public class AnswerAddCommandHandler : IRequestHandler<AnswerAddCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public AnswerAddCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(AnswerAddCommand request, CancellationToken cancellationToken)
        {
            var answer = new Answer
            {
                MessageBody = request.MessageBody,
                ClientId = request.ClientId,
                LawyerId = request.LawyerId,
                OfferId = request.OfferId,
                FromClient = request.FromClient,
                FromLawyer = request.FromLawyer,
            };

            _context.Answers.Add(answer);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>(answer.Id);
        }
    }
}
