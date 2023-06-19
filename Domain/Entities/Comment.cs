using Domain.Common;

namespace Domain.Entities
{
    public class Comment: EntityBase<int>
    {
        public Client? Client { get; set; }
        public int? ClientId { get; set; }
        public Lawyer? Lawyer { get; set; }
        public int? LawyerId { get; set; }
    }
}
