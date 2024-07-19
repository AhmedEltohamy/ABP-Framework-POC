using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductCategorization.Data;
using Volo.Abp.DependencyInjection;

namespace ProductCategorization.EntityFrameworkCore;

public class EntityFrameworkCoreProductCategorizationDbSchemaMigrator
    : IProductCategorizationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductCategorizationDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProductCategorizationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductCategorizationDbContext>()
            .Database
            .MigrateAsync();
    }
}
