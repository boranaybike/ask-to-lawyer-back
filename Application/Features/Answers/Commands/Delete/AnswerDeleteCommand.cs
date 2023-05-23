using Domain.Common;
using MediatR;

namespace Application.Features.Answers.Commands.Delete
{
    public class AnswerDeleteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
