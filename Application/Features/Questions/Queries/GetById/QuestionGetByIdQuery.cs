using MediatR;

namespace Application.Features.Questions.Queries.GetById
{
    public class QuestionGetByIdQuery:IRequest<List<QuestionGetByIdDto>>
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public QuestionGetByIdQuery(int id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}
