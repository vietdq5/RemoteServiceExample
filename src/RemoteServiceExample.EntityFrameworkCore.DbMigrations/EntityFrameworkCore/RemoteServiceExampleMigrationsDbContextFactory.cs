using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RemoteServiceExample.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class RemoteServiceExampleMigrationsDbContextFactory : IDesignTimeDbContextFactory<RemoteServiceExampleMigrationsDbContext>
    {
        public RemoteServiceExampleMigrationsDbContext CreateDbContext(string[] args)
        {
            RemoteServiceExampleEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<RemoteServiceExampleMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new RemoteServiceExampleMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../RemoteServiceExample.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
