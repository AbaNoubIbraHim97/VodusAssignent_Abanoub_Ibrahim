using Microsoft.EntityFrameworkCore;
using System;
using VodusAssignent_Abanoub_Ibrahim.Models;

namespace VodusAssignent_Abanoub_Ibrahim.Context
{
    public class ProductDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public ProductDbContext(IConfiguration configuration) => Configuration = configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Product> Product { get; set; }






    }
}
