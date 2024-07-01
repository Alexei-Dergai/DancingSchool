using DancingSchool_Models;
using Microsoft.EntityFrameworkCore;

namespace DancingSchool_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Feedback> Feedback { get; set; }
    }
}
