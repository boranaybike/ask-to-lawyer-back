using Domain.Common;
using MediatR;

namespace Application.Features.Questions.Commands.Delete
{
    public class QuestionDeleteCommand:IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
