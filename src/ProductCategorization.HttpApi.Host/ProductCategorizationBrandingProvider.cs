using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProductCategorization;

[Dependency(ReplaceServices = true)]
public class ProductCategorizationBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductCategorization";
}
