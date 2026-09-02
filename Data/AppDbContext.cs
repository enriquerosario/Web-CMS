using Microsoft.EntityFrameworkCore;
using CmsDemo.Models;

namespace CmsDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<Page> Pages { get; set; }
    }
}