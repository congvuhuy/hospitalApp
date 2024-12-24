using Volo.Abp.Settings;

namespace HospitalApp.Settings;

public class HospitalAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HospitalAppSettings.MySetting1));
    }
}
