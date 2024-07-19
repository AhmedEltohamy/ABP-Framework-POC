using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProductCategorization.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProductCategorizationDbContextFactory : IDesignTimeDbContextFactory<ProductCategorizationDbContext>
{
    public ProductCategorizationDbContext CreateDbContext(string[] args)
    {
        ProductCategorizationEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProductCategorizationDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProductCategorizationDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProductCategorization.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
