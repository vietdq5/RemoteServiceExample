using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RemoteServiceExample.Data;
using Volo.Abp.DependencyInjection;

namespace RemoteServiceExample.EntityFrameworkCore
{
    public class EntityFrameworkCoreRemoteServiceExampleDbSchemaMigrator
        : IRemoteServiceExampleDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreRemoteServiceExampleDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the RemoteServiceExampleMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<RemoteServiceExampleMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}