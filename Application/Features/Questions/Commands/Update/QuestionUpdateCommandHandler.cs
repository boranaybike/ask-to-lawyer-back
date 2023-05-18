using Application.Common.Interfaces;
using Domain.Common;
using MediatR;
using System.Net;

namespace Application.Features.Questions.Commands.Update
{
    public class QuestionUpdateCommandHandler : IRequestHandler<QuestionUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public QuestionUpdateCommandHandler (IApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public async Task<Response<int>> Handle(QuestionUpdateCommand request, CancellationToken cancellationToken)
        {
            var question = _context.Questions.FirstOrDefault(x => x.Id == request.Id);

            question.Title = request.Title;
            question.Description = request.Description;
            // question.Categories = request.Categories;
            question.MaxPrice = request.MaxPrice;
            question.MinPrice = request.MinPrice;

            await _context.SaveChangesAsync(cancellationToken);
            return new Response<int>($"question successfully updated.", question.Id);

        }
    }
}
