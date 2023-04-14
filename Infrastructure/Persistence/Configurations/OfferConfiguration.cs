using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {

            //Category kaldı!!(list olduğu için)
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Price
            builder.Property(x => x.Price).IsRequired();

            // IsAccepted
            builder.Property(x => x.IsAccepted).IsRequired();

            // Common Fields

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired(false);
            builder.Property(x => x.CreatedByUserId).HasMaxLength(100);

            // DeletedOn
            builder.Property(x => x.DeletedOn).IsRequired(false);

            // DeletedByUserId
            builder.Property(x => x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(100);

            // IsDeleted
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValueSql("0");
            builder.HasIndex(x => x.IsDeleted);

            // Relationships
            builder.HasOne<Lawyer>(x => x.Lawyer)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.LawyerId);

            builder.HasOne<Question>(x => x.Question)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.QuestionId);

            builder.HasOne<Answer>(x => x.Answer)
                .WithOne(x => x.Offer)
                .HasForeignKey(x => x.AnswerId);//hata veriyor

            builder.ToTable("Questions");
        }
    }
}
