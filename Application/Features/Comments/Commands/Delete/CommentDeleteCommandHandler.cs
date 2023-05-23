using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Comments.Commands.Delete
{
    public class CommentDeleteCommandHandler : IRequestHandler<CommentDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public CommentDeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(CommentDeleteCommand request, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.FindAsync(request.Id);

            if (comment == null)
            {
                // Handle not found condition
                throw new Exception($"Comment not found with ID: {request.Id}");
            }

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"successfully deleted.", comment.Id);
        }
    }
}
