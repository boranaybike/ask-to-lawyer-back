using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;
namespace Application.Features.Comments.Commands.Add
{
    public class CommentAddCommandHandler : IRequestHandler<CommentAddCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public CommentAddCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(CommentAddCommand request, CancellationToken cancellationToken)
        {
            var comment = new Comment
            {
                ClientId = request.ClientId,
                LawyerId = request.LawyerId
            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>($"offer succesfully added", comment.Id);
        }
    }
}
