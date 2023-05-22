using MediatR;

namespace Application.Features.Questions.Queries.GetById
{
    public class QuestionGetByIdQuery : IRequest<QuestionGetByIdDto>
    {
        public int Id { get; set; }

        public QuestionGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
