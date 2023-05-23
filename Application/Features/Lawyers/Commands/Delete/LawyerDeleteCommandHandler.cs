using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Lawyers.Commands.Delete
{
    public class LawyerDeleteCommandHandler : IRequestHandler<LawyerDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public LawyerDeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(LawyerDeleteCommand request, CancellationToken cancellationToken)
        {
            var lawyer = await _context.Lawyers.FindAsync(request.Id);

            if (lawyer == null)
            {
                throw new Exception($"Lawyer not found with ID: {request.Id}");
            }

            _context.Lawyers.Remove(lawyer);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>("Lawyer deleted successfully.", lawyer.Id);
        }
    }
}
