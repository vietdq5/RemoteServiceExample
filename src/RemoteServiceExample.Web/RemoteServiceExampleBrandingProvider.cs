using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RemoteServiceExample.Web
{
    [Dependency(ReplaceServices = true)]
    public class RemoteServiceExampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "RemoteServiceExample";
    }
}
