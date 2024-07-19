using System.Threading.Tasks;

namespace ProductCategorization.Data;

public interface IProductCategorizationDbSchemaMigrator
{
    Task MigrateAsync();
}
