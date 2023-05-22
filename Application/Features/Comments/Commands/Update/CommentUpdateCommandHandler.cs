using MediatR;
using Domain.Common;
using Application.Common.Interfaces;

namespace Application.Features.Comments.Commands.Update
{
    public class CommentUpdateCommandHandler : IRequestHandler<CommentUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public CommentUpdateCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(CommentUpdateCommand request, CancellationToken cancellationToken)
        {
            var comment = await _context.Comments.FindAsync(request.Id);

            if (comment == null)
            {
                throw new Exception($"Comment not found with ID: {request.Id}");
            }

            comment.ClientId = request.ClientId;
            comment.LawyerId = request.LawyerId;

            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>(comment.Id);
        }
    }
}
