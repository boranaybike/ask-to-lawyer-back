using Domain.Common;

namespace Domain.Entities
{
    public class Answer:EntityBase<int>
    {
        public string? MessageBody { get; set; }
        public Offer? Offer { get; set; }
        public int? OfferId { get; set;}
        public Client? Client { get; set; }
        public int? ClientId { get; set; }
        public Lawyer? Lawyer { get; set; }
        public int? LawyerId { get; set; }
        public bool? FromClient { get; set; }
        public bool? FromLawyer { get; set; }
    }
}
