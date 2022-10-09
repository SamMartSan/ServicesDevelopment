﻿using Microsoft.EntityFrameworkCore;
using PricatApp.Domain.Entities;

namespace PricatApp.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}