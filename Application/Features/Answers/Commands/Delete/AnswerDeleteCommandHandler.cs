using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Delete
{
    public class AnswerDeleteCommandHandler : IRequestHandler<AnswerDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public AnswerDeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(AnswerDeleteCommand request, CancellationToken cancellationToken)
        {
            var answer = await _context.Answers.FindAsync(request.Id);

            if (answer == null)
                throw new Exception($"Answer with ID '{request.Id}' not found.");

            _context.Answers.Remove(answer);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>("Answer deleted successfully.", answer.Id);
        }
    }
}
