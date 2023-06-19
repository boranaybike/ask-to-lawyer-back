using MediatR;

namespace Application.Features.Login
{
    public class LoginCommand: IRequest<LoginDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
