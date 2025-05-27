using Microsoft.EntityFrameworkCore;
using schoolmanagementsys.Models; // Change this to your actual namespace
namespace schoolmanagementsys.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
    }
}
