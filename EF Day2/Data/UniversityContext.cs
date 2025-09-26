using Microsoft.EntityFrameworkCore;
using WinForms_EF_CF.Models;

namespace WinForms_EF_CF.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5R1EPAT;Database=UniversityCF;Trusted_Connection=True;Encrypt=False");
        }
    }
}
