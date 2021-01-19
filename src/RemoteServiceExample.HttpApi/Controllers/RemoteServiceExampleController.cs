using RemoteServiceExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RemoteServiceExample.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class RemoteServiceExampleController : AbpController
    {
        protected RemoteServiceExampleController()
        {
            LocalizationResource = typeof(RemoteServiceExampleResource);
        }
    }
}