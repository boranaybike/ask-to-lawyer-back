using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Features.Questions.Queries.GetById
{
    public class QuestionGetByIdQueryHandler : IRequestHandler<QuestionGetByIdQuery, QuestionGetByIdDto>
    {
        private readonly IApplicationDbContext _context;
        public QuestionGetByIdQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public async Task<QuestionGetByIdDto> Handle(QuestionGetByIdQuery request, CancellationToken cancellationToken)
        {
            var question = await _context.Questions.FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);

            if (question == null)
                return null;

            var questionDto = new QuestionGetByIdDto()
            {
                Id = question.Id,
                Title = question.Title,
                Description = question.Description,
                //Categories = question.Categories,
                MaxPrice = question.MaxPrice,
                MinPrice = question.MinPrice,
                ClientId = question.ClientId,
                IsDeleted = question.IsDeleted,
            };

            return questionDto;
        }
    }
}