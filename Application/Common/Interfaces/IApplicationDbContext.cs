using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {

        DbSet<Answer> Answers { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Lawyer> Lawyers { get; set; }
        DbSet<Offer> Offers { get; set; }
        DbSet<Question> Questions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        int SaveChanges();
    }
}
