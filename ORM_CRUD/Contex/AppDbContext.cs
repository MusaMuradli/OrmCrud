using Microsoft.EntityFrameworkCore;
using ORM_CRUD.Models;

namespace ORM_CRUD.Contex
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=OrmCrud;trusted_connection=true;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
