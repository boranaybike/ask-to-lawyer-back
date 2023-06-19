using Domain.Common;
using MediatR;

namespace Application.Features.Lawyers.Commands.Update
{
    public class LawyerUpdateCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
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
        public string? Category { get; set; }

    }
}
