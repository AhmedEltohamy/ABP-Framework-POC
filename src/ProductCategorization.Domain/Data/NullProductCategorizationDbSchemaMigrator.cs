using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductCategorization.Data;

/* This is used if database provider does't define
 * IProductCategorizationDbSchemaMigrator implementation.
 */
public class NullProductCategorizationDbSchemaMigrator : IProductCategorizationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
