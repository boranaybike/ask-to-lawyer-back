using Application.Common.Interfaces;
using Domain.Common;
using MediatR;

namespace Application.Features.Clients.Commands.Delete
{
    public class ClientDeleteCommandHandler : IRequestHandler<ClientDeleteCommand, Response<int>>
    {
        private readonly IApplicationDbContext _context;

        public ClientDeleteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response<int>> Handle(ClientDeleteCommand request, CancellationToken cancellationToken)
        {
            var client = await _context.Clients.FindAsync(request.Id);

            if (client == null)
            {
                // İstisna fırlat veya hata mesajı döndür
            }

            // Silme işlemini gerçekleştir
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync(cancellationToken);

            return new Response<int>();
        }
    }
}
