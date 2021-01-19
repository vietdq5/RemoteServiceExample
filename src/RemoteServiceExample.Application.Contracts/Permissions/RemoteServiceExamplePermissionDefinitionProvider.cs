using RemoteServiceExample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RemoteServiceExample.Permissions
{
    public class RemoteServiceExamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(RemoteServiceExamplePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(RemoteServiceExamplePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<RemoteServiceExampleResource>(name);
        }
    }
}
