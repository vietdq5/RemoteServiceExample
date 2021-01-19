using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using RemoteServiceExample.Localization;
using RemoteServiceExample.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace RemoteServiceExample.Web.Menus
{
    public class RemoteServiceExampleMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<RemoteServiceExampleResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(RemoteServiceExampleMenus.Home, l["Menu:Home"], "~/"));
            context.Menu.AddItem(
                new ApplicationMenuItem(RemoteServiceExampleMenus.Book, l["Menu:Book"], "/Entities/Book")
            );
        }
    }
}
