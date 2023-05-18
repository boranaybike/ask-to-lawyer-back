using Domain.Common;

namespace Domain.Entities
{
    public class Question:EntityBase<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        // public List<string> Categories { get; set; }
        public int? MaxPrice { get; set; }
        public int? MinPrice { get; set; }
        public Client? Client { get; set; }
        public int ClientId { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        
    }
}
