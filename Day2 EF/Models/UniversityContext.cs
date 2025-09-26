using Microsoft.EntityFrameworkCore;
namespace WinFormsEfCrud.Models
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Students { get; set; } 

        public UniversityContext()
        {
        }

        // edit this connection string to match your environment or use appsettings + DI
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=University;Trusted_Connection=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).HasMaxLength(100);
                entity.Property(e => e.LastName).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(200);
            });
        }
    }
}

