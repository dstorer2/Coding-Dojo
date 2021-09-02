using Microsoft.EntityFrameworkCore;
namespace BeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users{get; set; }
        public DbSet<Gathering> Gatherings{get; set; }
        public DbSet<Attendance> Attendances{get; set; }
    }
}