namespace Application.Features.Lawyers.Commands.Add
{
    public class LawyerRegisterDto
    {

        public string Email { get; set; }
        public string FullName { get; set; }
        public string ActivationToken { get; set; }

        public LawyerRegisterDto(string email, string fullName, string activationToken)
        {

            Email = email;
            FullName = fullName;
            ActivationToken = activationToken;
        }
    }
}
