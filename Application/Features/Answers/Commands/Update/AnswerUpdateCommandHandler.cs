using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Update
{
    public class AnswerUpdateCommandHandler : IRequestHandler<AnswerUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public AnswerUpdateCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(AnswerUpdateCommand request, CancellationToken cancellationToken)
        {
            var answer = await _context.Answers.FindAsync(request.Id);

            if (answer == null)
                throw new Exception($"Answer with ID '{request.Id}' not found.");

            // Update answer properties
            answer.Title = request.Title;
            answer.Date = request.Date;
            answer.OfferAcceptDate = request.OfferAcceptDate;

            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>("Answer updated successfully.", answer.Id);
        }
    }
}
