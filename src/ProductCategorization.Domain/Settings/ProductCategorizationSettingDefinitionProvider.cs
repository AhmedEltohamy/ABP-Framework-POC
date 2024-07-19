using Volo.Abp.Settings;

namespace ProductCategorization.Settings;

public class ProductCategorizationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductCategorizationSettings.MySetting1));
    }
}
