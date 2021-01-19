using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace RemoteServiceExample.EntityFrameworkCore
{
    [DependsOn(
        typeof(RemoteServiceExampleEntityFrameworkCoreModule)
        )]
    public class RemoteServiceExampleEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RemoteServiceExampleMigrationsDbContext>();
        }
    }
}
