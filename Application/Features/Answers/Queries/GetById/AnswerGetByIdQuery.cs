using MediatR;

namespace Application.Features.Answers.Queries.GetById
{
    public class AnswerGetByIdQuery : IRequest<AnswerGetByIdDto>
    {
        public int Id { get; set; }

        public AnswerGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
