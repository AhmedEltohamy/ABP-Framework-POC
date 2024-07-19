using Volo.Abp.Modularity;

namespace ProductCategorization;

[DependsOn(
    typeof(ProductCategorizationDomainModule),
    typeof(ProductCategorizationTestBaseModule)
)]
public class ProductCategorizationDomainTestModule : AbpModule
{

}
