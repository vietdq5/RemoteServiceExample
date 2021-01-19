using Volo.Abp.Settings;

namespace RemoteServiceExample.Settings
{
    public class RemoteServiceExampleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(RemoteServiceExampleSettings.MySetting1));
        }
    }
}
