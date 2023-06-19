using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IJwtService _jwtService;
        public LoginCommandHandler(IApplicationDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }
        public async Task<LoginDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {

            var client = await _context.Clients.FirstOrDefaultAsync(c => c.Email == request.Email);
            var lawyer = await _context.Lawyers.FirstOrDefaultAsync(l => l.Email == request.Email);

            if (client == null && lawyer == null)
            {
                throw new Exception("Geçersiz kullanıcı adı veya şifre");
            }

            string role;
            if (client != null)
            {
                role = "client";
                if(client.Password == request.Password)
                {
                    var jwtDto = _jwtService.Generate(client.Id, client.FirstName, client.LastName, request.Email, role);
                    return new LoginDto(jwtDto.AccessToken);
                }
                else
                {
                    throw new Exception("Geçersiz kullanıcı adı veya şifre");

                }
            }
            else
            {
                role = "lawyer";
                if(lawyer.Password == request.Password)
                {
                    var jwtDto = _jwtService.Generate(lawyer.Id, lawyer.FirstName, lawyer.LastName, request.Email, role);
                    return new LoginDto(jwtDto.AccessToken);
                }

                else
                {
                    throw new Exception("Geçersiz kullanıcı adı veya şifre");
                }
            }            
            return new LoginDto("success!!!!!!");
        }

    }
}