using RemoteServiceExample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace RemoteServiceExample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class RemoteServiceExamplePageModel : AbpPageModel
    {
        protected RemoteServiceExamplePageModel()
        {
            LocalizationResourceType = typeof(RemoteServiceExampleResource);
        }
    }
}