using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class LawyerConfiguration : IEntityTypeConfiguration<Lawyer>
    {
        public void Configure(EntityTypeBuilder<Lawyer> builder)
        {

            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // BarNo
            builder.Property(x => x.BarNo).IsRequired();

            // Bio
            builder.Property(x => x.Bio).IsRequired(false);

            // Education
            builder.Property(x => x.Education).IsRequired(false);

            // AverageResponseTime
            builder.Property(x => x.AverageResponseTime).IsRequired(false);

            // AverageRate
            builder.Property(x => x.AverageRate).IsRequired(false);

            // Relationships
            builder.HasMany(x => x.Comments)
                .WithOne(x => x.Lawyer)
                .HasForeignKey(x => x.LawyerId);

            builder.HasMany(x => x.Offers)
                .WithOne(x => x.Lawyer)
                .HasForeignKey(x => x.LawyerId);

            builder.ToTable("Lawyers");
        }
    }
}
