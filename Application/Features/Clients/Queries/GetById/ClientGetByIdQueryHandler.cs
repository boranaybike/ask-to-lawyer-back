using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;


namespace Application.Features.Clients.Queries.GetById
{
    public class ClientGetByIdQueryHandler : IRequestHandler<ClientGetByIdQuery, ClientGetByIdDto>
    {
        private readonly IApplicationDbContext _context;

        public ClientGetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ClientGetByIdDto> Handle(ClientGetByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (client == null)
            {
                throw new Exception();
            }

            var clientDto = new ClientGetByIdDto
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                Phone = client.Phone
            };

            return clientDto;
        }
    }
}
