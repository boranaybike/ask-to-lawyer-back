using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Clients.Queries.GetAll
{
    public class ClientGetAllQueryHandler : IRequestHandler<ClientGetAllQuery, List<ClientGetAllDto>>
    {
        private readonly IApplicationDbContext _context;

        public ClientGetAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ClientGetAllDto>> Handle(ClientGetAllQuery request, CancellationToken cancellationToken)
        {
            var clients = await _context.Clients
                .Select(c => new ClientGetAllDto
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Phone = c.Phone
                })
                .ToListAsync(cancellationToken);

            return clients;
        }
    }
}
