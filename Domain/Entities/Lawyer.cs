namespace Domain.Entities
{
    public class Lawyer: User
    {
        public int BarNo { get; set; }
        public string? Bio { get; set; }
        public string Education { get; set; }
        public DateTimeOffset ExperienceDate { get; set; }
        public List<string> Categories { get; set; }
        public int AverageResponseTime { get; set; }
        public float AverageRate { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Offer>? Offers { get; set; }
    }
}
