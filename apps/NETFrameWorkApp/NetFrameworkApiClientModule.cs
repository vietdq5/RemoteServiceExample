using Microsoft.Extensions.DependencyInjection;
using RemoteServiceExample;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace NETFrameWorkApp
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class NetFrameworkApiClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpRemoteServiceOptions>(options =>
            {
                options.RemoteServices.Default =
                    new RemoteServiceConfiguration("https://localhost:44359");
            });
            context.Services.AddHttpClientProxies(
                    typeof(RemoteServiceExampleApplicationContractsModule).Assembly,
                    remoteServiceConfigurationName: "Default"
);
            context.Services.AddSingleton<Form1>();
        }
    }
}
