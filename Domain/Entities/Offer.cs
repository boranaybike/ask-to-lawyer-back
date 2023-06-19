using Domain.Common;

namespace Domain.Entities
{
    public class Offer: EntityBase<int>
    {
        public Lawyer? Lawyer { get; set; }
        public int? LawyerId { get; set; }
        public Question? Question { get; set; }
        public int? QuestionId { get; set; }
        public Answer? Answer { get; set; }
        public int? AnswerId { get; set; }
        public int? Price { get; set; }
        public bool? IsAccepted { get; set; }
        public DateTimeOffset? AcceptDate { get; set; }

    }
}
