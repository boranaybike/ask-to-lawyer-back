using static Application.Common.Helpers.MessagesHelper;

namespace Application.Features.Clients.Commands.Add
{
    public class ClientRegisterDto
    {

        public string Email { get; set; }
        public string FullName { get; set; }
        public string ActivationToken { get; set; }

        public ClientRegisterDto(string email, string fullName, string activationToken) {

            Email = email;
            FullName = fullName;
            ActivationToken = activationToken;
        }
    }
}
