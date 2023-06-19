using Application.Common.Models.Auth;
using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IJwtService
    {
        JwtDto Generate(int userId,string email, string firstName, string lastName, string role);
    }
}
