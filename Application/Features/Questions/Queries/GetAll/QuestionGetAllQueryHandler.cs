using Application.Common.Interfaces;
using MediatR;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Application.Features.Questions.Queries.GetAll
{
    public class QuestionGetAllQueryHandler : IRequestHandler<QuestionGetAllQuery, List<QuestionGetAllDto>>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public QuestionGetAllQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<QuestionGetAllDto>> Handle(QuestionGetAllQuery request, CancellationToken cancellationToken)
        {
            var dbQuery = _applicationDbContext.Questions.AsQueryable();

            dbQuery = dbQuery.Where(x => x.ClientId == request.ClientId);

            dbQuery = dbQuery.Include(x => x.Client);

            var questions = await dbQuery.ToListAsync(cancellationToken);

            var questionDtos = MapQuestionsToGetAllDtos(questions);

            return questionDtos.ToList();
        }
        private IEnumerable<QuestionGetAllDto> MapQuestionsToGetAllDtos(List<Question> questions)
        {
            List<QuestionGetAllDto> questionGetAllDtos = new();

            foreach (var question in questions)
            {

                yield return new QuestionGetAllDto()
                {
                    Id=question.Id,
                    Title=question.Title,
                    Description=question.Description,
                    Categories=question.Categories,
                    MaxPrice=question.MaxPrice,
                    MinPrice=question.MinPrice,
                    ClientId=question.ClientId,
                    ClientName=question.Client.FirstName,
                    IsDeleted=question.IsDeleted,
                };
            }
        }
    }
}
