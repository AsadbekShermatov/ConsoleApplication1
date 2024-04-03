using ConsoleApplication1.User;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication1.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-G3SP2SRJPL7; Database=StudentDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

            
    }
}
