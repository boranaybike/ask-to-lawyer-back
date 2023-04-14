using Domain.Common;

namespace Domain.Entities
{
    public class Answer:EntityBase<int>
    {
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset OfferAcceptDate { get; set; }
        public Offer? Offer { get; set; }
        public int OfferId { get; set;}

    }
}
