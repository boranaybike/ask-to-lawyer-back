using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Clients.Commands.Update
{
    public class ClientUpdateCommandHandler : IRequestHandler<ClientUpdateCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public ClientUpdateCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(ClientUpdateCommand request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Id);

            if (client == null)
            {
                throw new ArgumentException();
            }

            client.FirstName = request.FirstName;
            client.LastName = request.LastName;
            client.Email = request.Email;
            client.Phone = request.Phone;
            client.Password = request.Password;

            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>();
        }
    }
}
