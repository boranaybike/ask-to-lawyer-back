using MediatR;

namespace Application.Features.Answers.Queries.GetAll
{
    public class AnswerGetAllQuery : IRequest<AnswerGetAllDto[]>
    {
    }
}
