using Domain.Common;
using MediatR;

namespace Application.Features.Comments.Commands.Delete
{
    public class CommentDeleteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
}
