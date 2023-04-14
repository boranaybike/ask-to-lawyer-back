using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Questions.Commands.Add
{
    public class QuestionAddCommandHandler : IRequestHandler<QuestionAddCommand, Response<int>>
    {

        private readonly IApplicationDbContext _applicationDbContext;
        public QuestionAddCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Response<int>> Handle(QuestionAddCommand request, CancellationToken cancellationToken)
        {
            var question = new Question
            {
                Title = request.Title,
                Description = request.Description,
                Categories = request.Categories,
                MaxPrice = request.MaxPrice,
                MinPrice = request.MinPrice,
                ClientId = request.ClientId,
                IsDeleted = false,
                CreatedOn = DateTimeOffset.Now,
                CreatedByUserId = null,

            };

            await _applicationDbContext.Questions.AddAsync(question, cancellationToken);

            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<int>($"The new addres named \"{question.Title}\" was successfully added.", question.Id);
        }
    }
}
