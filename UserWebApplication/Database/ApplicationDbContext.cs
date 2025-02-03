using Microsoft.EntityFrameworkCore;
using UserWebApplication.Models;

namespace UserWebApplication.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }

}
