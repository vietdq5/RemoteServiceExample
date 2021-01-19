using RemoteServiceExample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RemoteServiceExample.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(RemoteServiceExampleEntityFrameworkCoreDbMigrationsModule),
        typeof(RemoteServiceExampleApplicationContractsModule)
        )]
    public class RemoteServiceExampleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
