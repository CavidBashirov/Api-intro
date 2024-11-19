﻿using Api_intro.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_intro.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Country> Countries { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
              new Country { Id = 1, Name = "Azerbaycan", Population = 11000000 },
              new Country { Id = 2, Name = "Turkiye", Population = 60000000 }
            );
        }
    }
}
