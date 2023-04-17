using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Questions.Commands.Delete
{
    public class QuestionDeleteCommandHandler : IRequestHandler<QuestionDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public QuestionDeleteCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<Response<int>> Handle(QuestionDeleteCommand request, CancellationToken cancellationToken)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == request.Id);

            if (question is null)
            {
                throw new ArgumentException();
            }

            question.IsDeleted = true;
            question.DeletedOn = DateTimeOffset.Now;

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"successfully deleted.", question.Id);

        }
    }
}


