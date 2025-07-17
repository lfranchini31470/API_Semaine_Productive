using API_Semaine_Productive.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Semaine_Productive.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
