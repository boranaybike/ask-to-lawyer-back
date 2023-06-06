using Domain.Common;
using Domain.Identity;

namespace Domain.Entities
{
    public class Lawyer : EntityBase<int>
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
        public DateTimeOffset? ExperienceDate { get; set; }

        // public List<string> Categories { get; set; }
        public int? AverageResponseTime { get; set; }
        public float? AverageRate { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Offer>? Offers { get; set; }
    }
}
