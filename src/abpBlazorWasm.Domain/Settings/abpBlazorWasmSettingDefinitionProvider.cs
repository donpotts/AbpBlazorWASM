using Volo.Abp.Settings;

namespace abpBlazorWasm.Settings;

public class abpBlazorWasmSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(abpBlazorWasmSettings.MySetting1));
    }
}
