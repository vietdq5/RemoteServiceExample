using RemoteServiceExample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RemoteServiceExample
{
    [DependsOn(
        typeof(RemoteServiceExampleEntityFrameworkCoreTestModule)
        )]
    public class RemoteServiceExampleDomainTestModule : AbpModule
    {

    }
}