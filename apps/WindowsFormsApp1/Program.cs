using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Volo.Abp;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IHost host = Host
               .CreateDefaultBuilder(null)
               .UseAutofac()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddApplication<WinFormModule>();
               }).Build();
            IAbpApplicationWithExternalServiceProvider application = host.Services.GetService<IAbpApplicationWithExternalServiceProvider>();
            await host.StartAsync();
            application.Initialize(host.Services);
            var form1 = host.Services.GetService<Form1>();
            Application.Run(form1);
            application.Shutdown();
            await host.StopAsync();
            host.Dispose();
        }
    }
}