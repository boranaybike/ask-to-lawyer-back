using Domain.Common;

namespace Domain.Entities
{
    public class Client: EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}
