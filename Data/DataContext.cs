using Microsoft.EntityFrameworkCore;
using CouchSignal.Models;

namespace CouchSignal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new {ID = (long) 1, Name = "Admin"},
                new {ID = (long) 2, Name = "User"},
                new {ID = (long) 3, Name = "Device"});
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}