using Volo.Abp.Modularity;

namespace ProductCategorization;

public abstract class ProductCategorizationApplicationTestBase<TStartupModule> : ProductCategorizationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
