using Domain.Common;
using MediatR;

namespace Application.Features.Comments.Commands.Add
{
    public class CommentAddCommand : IRequest<Response<int>>
    {
        public int ClientId { get; set; }
        public int LawyerId { get; set; }
    }
}
