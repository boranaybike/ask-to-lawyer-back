using Application.Common.Interfaces;
using MediatR;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Application.Features.Questions.Queries.GetById
{
    public class QuestionGetByIdQueryHandler : IRequestHandler<QuestionGetByIdQuery, List<QuestionGetByIdDto>>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public QuestionGetByIdQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<QuestionGetByIdDto>> Handle(QuestionGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbQuery = _applicationDbContext.Questions.AsQueryable();

            dbQuery = dbQuery.Where(x => x.Id == request.Id);

            dbQuery = dbQuery.Include(x => x.Client);

            var questions = await dbQuery.ToListAsync(cancellationToken);

            var questionDtos = MapQuestionsToGetAllDtos(questions);

            return questionDtos.ToList();
        }
        private IEnumerable<QuestionGetByIdDto> MapQuestionsToGetAllDtos(List<Question> questions)
        {
            List<QuestionGetByIdDto> questionGetAllDtos = new();

            foreach (var question in questions)
            {

                yield return new QuestionGetByIdDto()
                {
                    Id = question.Id,
                    Title = question.Title,
                    Description = question.Description,
                    //Categories = question.Categories,
                    MaxPrice = question.MaxPrice,
                    MinPrice = question.MinPrice,
                    ClientId = question.ClientId,
                    ClientName = question.Client.FirstName,
                    IsDeleted = question.IsDeleted,
                };
            }
        }
    }
}