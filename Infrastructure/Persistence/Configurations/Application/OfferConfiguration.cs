﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {

            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Price
            builder.Property(x => x.Price).IsRequired(false);

            // IsAccepted
            builder.Property(x => x.IsAccepted).IsRequired(false);

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
            builder.HasOne(x => x.Lawyer)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.LawyerId);

            builder.HasOne(x => x.Question)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.QuestionId);

            builder.HasOne(x => x.Answer)
                .WithOne(x => x.Offer)
                .HasForeignKey<Answer>(x => x.OfferId);

            builder.ToTable("Offers");
        }
    }
}
