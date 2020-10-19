using Microsoft.EntityFrameworkCore;

namespace AdminApi.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> TodoItems { get; set; }
    }
}