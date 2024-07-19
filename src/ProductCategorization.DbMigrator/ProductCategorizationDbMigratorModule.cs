using ProductCategorization.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProductCategorization.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductCategorizationEntityFrameworkCoreModule),
    typeof(ProductCategorizationApplicationContractsModule)
    )]
public class ProductCategorizationDbMigratorModule : AbpModule
{
}
