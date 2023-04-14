using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
                       
            // Relationships
            builder.HasMany<Comment>(x => x.Comments)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId);
            // Relationships
            builder.HasMany<Question>(x => x.Questions)
                .WithOne(x => x.Client)
                .HasForeignKey(x => x.ClientId);

            builder.ToTable("Clients");
        }
    }
}
