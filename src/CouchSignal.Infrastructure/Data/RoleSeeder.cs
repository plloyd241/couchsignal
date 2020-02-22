using CouchSignal.Core.Models;

namespace CouchSignal.Infrastructure.Data
{
    public static class RoleSeeder
    {
        public static void Run(IServiceProvider provider)
        {
            using (var context = new DeviceContext(
                provider.GetRequiredService<DbContextOptions<DeviceContext>>()))
            {
                // if any roles exist, exit because the DB has been seeded
                if (context.Roles.Any())
                {
                    return;
                }

                context.Roles.AddRange(
                    new Role
                    {
                        Name = Role.ADMIN
                    },
                    new Role
                    {
                        Name = Role.FOREMAN
                    },
                    new Role
                    {
                        Name = Role.WORKER
                    }
                );

                context.SaveChanged();
            }
        }
    }
}