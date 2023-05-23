using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Clients.Commands.Add
{
    public class ClientAddCommandHandler : IRequestHandler<ClientAddCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public ClientAddCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(ClientAddCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Password = request.Password
            };

            _context.Clients.Add(client);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>(client.Id);
        }
    }
}
