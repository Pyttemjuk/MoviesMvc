using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MoviesMvc.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .Property(o => o.ReleaseDate)
                .HasColumnType(SqlDbType.Date.ToString());
        }
    }
}
