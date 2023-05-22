using Application.Common.Interfaces;
using MediatR;
namespace Application.Features.Comments.Queries.GetById
{
    public class CommentGetByIdQueryHandler : IRequestHandler<CommentGetByIdQuery, CommentGetByIdDto>
    {
        private readonly IApplicationDbContext _context;

        public CommentGetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CommentGetByIdDto> Handle(CommentGetByIdQuery request, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.FindAsync(request.Id);

            if (comment == null)
            {
                throw new Exception();
            }

            var commentDto = new CommentGetByIdDto
            {
                Id = comment.Id,
                ClientId = comment.ClientId,
                LawyerId = comment.LawyerId
            };

            return commentDto;
        }
    }
}
