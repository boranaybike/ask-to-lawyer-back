﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Persistence.Migrations.Identity
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20230617135955_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("FromClient")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("FromLawyer")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("LawyerId")
                        .HasColumnType("int");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ModifiedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("LawyerId");

                    b.HasIndex("OfferId")
                        .IsUnique();

                    b.ToTable("Answers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("LawyerId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("LawyerId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Lawyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float?>("AverageRate")
                        .HasColumnType("float");

                    b.Property<int?>("AverageResponseTime")
                        .HasColumnType("int");

                    b.Property<string>("Bar")
                        .HasColumnType("longtext");

                    b.Property<int?>("BarNo")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Education")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ExperienceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Lawyers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("AcceptDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("IsAccepted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("LawyerId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("LawyerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Offers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DeletedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool?>("HasAnswer")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("HasOffer")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("MaxPrice")
                        .HasColumnType("int");

                    b.Property<int?>("MinPrice")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedByUserId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(191)
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(191)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ModifiedByUserId")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(191)
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(191)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(191)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(191)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(191)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.UserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(191)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)");

                    b.Property<string>("Name")
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Answer", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Domain.Entities.Lawyer", "Lawyer")
                        .WithMany()
                        .HasForeignKey("LawyerId");

                    b.HasOne("Domain.Entities.Offer", "Offer")
                        .WithOne("Answer")
                        .HasForeignKey("Domain.Entities.Answer", "OfferId");

                    b.Navigation("Client");

                    b.Navigation("Lawyer");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Comments")
                        .HasForeignKey("ClientId");

                    b.HasOne("Domain.Entities.Lawyer", "Lawyer")
                        .WithMany("Comments")
                        .HasForeignKey("LawyerId");

                    b.Navigation("Client");

                    b.Navigation("Lawyer");
                });

            modelBuilder.Entity("Domain.Entities.Offer", b =>
                {
                    b.HasOne("Domain.Entities.Lawyer", "Lawyer")
                        .WithMany("Offers")
                        .HasForeignKey("LawyerId");

                    b.HasOne("Domain.Entities.Question", "Question")
                        .WithMany("Offers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("Lawyer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Questions")
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Domain.Identity.RoleClaim", b =>
                {
                    b.HasOne("Domain.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Identity.UserClaim", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Identity.UserLogin", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Identity.UserRole", b =>
                {
                    b.HasOne("Domain.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Identity.UserToken", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Domain.Entities.Lawyer", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Domain.Entities.Offer", b =>
                {
                    b.Navigation("Answer");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
