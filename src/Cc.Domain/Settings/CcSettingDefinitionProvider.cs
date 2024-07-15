using Volo.Abp.Settings;

namespace Cc.Settings;

public class CcSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CcSettings.MySetting1));
    }
}
