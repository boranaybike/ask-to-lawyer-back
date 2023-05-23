using MediatR;

namespace Application.Features.Questions.Queries.GetAll
{
    public class QuestionGetAllQuery : IRequest<List<QuestionGetAllDto>>
    {
    }
}
