using MediatR;

namespace Application.Features.Questions.Queries.GetAll
{
    public class QuestionGetAllQuery:IRequest<List<QuestionGetAllDto>>
    {
        public int ClientId { get; set; }
        public bool IsDeleted { get; set; }

        public QuestionGetAllQuery(int clientId, bool isDeleted)
        {
            ClientId = clientId;
            IsDeleted = isDeleted;
        }
    }
}
