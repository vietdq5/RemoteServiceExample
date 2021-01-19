using Microsoft.Extensions.DependencyInjection;
using Polly;
using RemoteServiceExample;
using System;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace WindowsFormsApp
{
    [DependsOn(
         typeof(AbpAutofacModule),
         typeof(RemoteServiceExampleHttpApiClientModule),
         typeof(AbpHttpClientIdentityModelModule)
        )]
    public class WinFormModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<AbpHttpClientBuilderOptions>(options =>
            {
                options.ProxyClientBuildActions.Add((remoteServiceName, clientBuilder) =>
                {
                    clientBuilder.AddTransientHttpErrorPolicy(
                        policyBuilder => policyBuilder.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(Math.Pow(2, i)))
                    );
                });
            });
            context.Services.AddTransient<Form1>();
        }
    }
}