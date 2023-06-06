namespace Application.Features.Auth.Commands.Register
{
    public class AuthRegisterDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }

        public AuthRegisterDto(string email, string fullName)
        {
            Email = email;
            FullName =fullName;
        }
    }
}
