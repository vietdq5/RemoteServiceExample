using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using Volo.Abp;

namespace NETFrameWorkApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IHost host = Host
                .CreateDefaultBuilder(null)
                .UseAutofac()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddApplication<NetFrameworkApiClientModule>();
                }).Build();
            IAbpApplicationWithExternalServiceProvider application = host.Services.GetService<IAbpApplicationWithExternalServiceProvider>();
            Application.Run(new Form1());
        }
    }
}