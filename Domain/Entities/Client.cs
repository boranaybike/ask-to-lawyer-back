using Domain.Identity;

namespace Domain.Entities
{
    public class Client: User
    {
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}
