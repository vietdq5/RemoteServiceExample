using System;
using System.Collections.Generic;
using System.Text;
using RemoteServiceExample.Localization;
using Volo.Abp.Application.Services;

namespace RemoteServiceExample
{
    /* Inherit your application services from this class.
     */
    public abstract class RemoteServiceExampleAppService : ApplicationService
    {
        protected RemoteServiceExampleAppService()
        {
            LocalizationResource = typeof(RemoteServiceExampleResource);
        }
    }
}
