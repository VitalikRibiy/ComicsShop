using System;
using System.Collections.Generic;
using System.Text;
using ComicsShopDAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComicsShopDAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            new DataSeeder(this);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
