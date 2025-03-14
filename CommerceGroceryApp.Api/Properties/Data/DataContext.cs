﻿using CommerceGroceryApp.Api.Properties.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CommerceGroceryApp.Api.Properties.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeeData(ref modelBuilder);
        }

        private static void SeeData(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasData(Role.GetInitialRoles());
            modelBuilder.Entity<User>()
                .HasData(User.GetInitialUsers());
        }
    }
}
