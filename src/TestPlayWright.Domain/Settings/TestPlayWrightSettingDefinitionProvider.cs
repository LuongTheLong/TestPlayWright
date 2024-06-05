using Volo.Abp.Settings;

namespace TestPlayWright.Settings;

public class TestPlayWrightSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestPlayWrightSettings.MySetting1));
    }
}
