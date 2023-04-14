﻿using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Common.Interfaces;

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

    }
}
