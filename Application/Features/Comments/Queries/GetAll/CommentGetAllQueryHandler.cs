using Application.Common.Interfaces;
using MediatR;
namespace Application.Features.Comments.Queries.GetAll
{
    public class CommentGetAllQueryHandler : IRequestHandler<CommentGetAllQuery, List<CommentGetAllDto>>
    {
        private readonly IApplicationDbContext _context;

        public CommentGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CommentGetAllDto>> Handle(CommentGetAllQuery request, CancellationToken cancellationToken)
        {
            var comments = _context.Comments.Select(c => new CommentGetAllDto
            {
                Id = c.Id,
                ClientId = c.ClientId,
                LawyerId = c.LawyerId
            }).ToList();

            return comments;
        }
    }
}
