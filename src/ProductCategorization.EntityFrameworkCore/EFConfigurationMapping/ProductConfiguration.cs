using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategorization.Products;

namespace ProductCategorization.EFConfigurationMapping;

internal class ProductConfiguration : AggregateRootConfiguration<Product, int>
{
    public override void Configure(EntityTypeBuilder<Product> builder)
    {
        base.Configure(builder);

        builder.Property(p => p.Name).IsRequired();

        builder.HasIndex(p => p.Name).IsUnique();

        builder.Property(p => p.Price).IsRequired();

        builder.HasMany(p => p.Categories).WithMany();

        builder.Navigation(p => p.Categories).AutoInclude();
    }
}