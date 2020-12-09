using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vatan.Models.ORM.Entities;

namespace Vatan.Models.ORM.Context
{
    public class VatanContext : DbContext
    {
        public VatanContext(DbContextOptions<VatanContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }





    }
}

