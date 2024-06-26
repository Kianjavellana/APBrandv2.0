using APBrandv2._0.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APBrandv2._0.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Review> Reviews { get; set; }

        
    }
}
