using Volo.Abp.Modularity;

namespace ProductCategorization;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductCategorizationDomainTestBase<TStartupModule> : ProductCategorizationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
