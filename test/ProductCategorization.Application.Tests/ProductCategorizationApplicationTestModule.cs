using Volo.Abp.Modularity;

namespace ProductCategorization;

[DependsOn(
    typeof(ProductCategorizationApplicationModule),
    typeof(ProductCategorizationDomainTestModule)
)]
public class ProductCategorizationApplicationTestModule : AbpModule
{

}
