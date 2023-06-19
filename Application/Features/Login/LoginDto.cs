namespace Application.Features.Login
{
    public class LoginDto
    {
        public string AccessToken { get; set; }

        public LoginDto(string accessToken)
        {
            AccessToken = accessToken;

        }
    }
}
