using Domain.Common;
using MediatR;

namespace Application.Features.Comments.Commands.Update
{
    public class CommentUpdateCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LawyerId { get; set; }


    }
}
