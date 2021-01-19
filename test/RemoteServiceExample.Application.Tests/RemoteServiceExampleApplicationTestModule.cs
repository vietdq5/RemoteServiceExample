using Volo.Abp.Modularity;

namespace RemoteServiceExample
{
    [DependsOn(
        typeof(RemoteServiceExampleApplicationModule),
        typeof(RemoteServiceExampleDomainTestModule)
        )]
    public class RemoteServiceExampleApplicationTestModule : AbpModule
    {

    }
}