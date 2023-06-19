using Domain.Common;
using MediatR;

namespace Application.Features.Lawyers.Commands.Add
{
    public class LawyerAddCommand : IRequest<LawyerRegisterDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int BarNo { get; set; }
        public string Bar { get; set; }
        public string? Bio { get; set; }
        public string Education { get; set; }
        public DateTimeOffset ExperienceDate { get; set; }
        public int AverageResponseTime { get; set; }
        public float AverageRate { get; set; }
    }
}
