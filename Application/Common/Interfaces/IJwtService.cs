using Application.Common.Models.Auth;

namespace Application.Common.Interfaces
{
    public interface IJwtService
    {
        JwtDto Generate(int userId,string email, string firstName, string lastName, List<string>? roles = null);
    }
}
