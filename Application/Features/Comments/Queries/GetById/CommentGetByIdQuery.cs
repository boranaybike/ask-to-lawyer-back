using MediatR;

namespace Application.Features.Comments.Queries.GetById
{
    public class CommentGetByIdQuery : IRequest<CommentGetByIdDto>
    {
        public int Id { get; set; }
        public CommentGetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
