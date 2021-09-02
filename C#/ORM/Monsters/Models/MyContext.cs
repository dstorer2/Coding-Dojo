using Microsoft.EntityFrameworkCore;
namespace Monsters.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<Monster> Monsters {get; set; }
    }
}