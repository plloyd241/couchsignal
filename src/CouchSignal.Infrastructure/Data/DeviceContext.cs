using CouchSignal.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CouchSignal.Infrastructure.Data
{
    class DeviceContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}