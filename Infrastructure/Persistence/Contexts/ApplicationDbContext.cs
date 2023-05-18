using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Common.Interfaces;
using Domain.Identity;
using System.Reflection;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Question> Questions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configurations
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Ignores
            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Role>();
            modelBuilder.Ignore<UserRole>();
            modelBuilder.Ignore<RoleClaim>();
            modelBuilder.Ignore<UserToken>();
            modelBuilder.Ignore<UserClaim>();
            modelBuilder.Ignore<UserLogin>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
