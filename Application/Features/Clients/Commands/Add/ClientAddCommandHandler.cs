using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Clients.Commands.Add
{
    public class ClientAddCommandHandler : IRequestHandler<ClientAddCommand, ClientRegisterDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IJwtService _jwtService;

        public ClientAddCommandHandler(IApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<ClientRegisterDto> Handle(ClientAddCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Password = request.Password
            };
            var fullName = client.FirstName + client.LastName;

            _context.Clients.Add(client);
            await _context.SaveChangesAsync(cancellationToken);

            var jwtDto = _jwtService.Generate(client.Id, request.Email, request.FirstName, request.LastName);
            return new ClientRegisterDto(request.Email, fullName, jwtDto.AccessToken);
        }
    }
}
