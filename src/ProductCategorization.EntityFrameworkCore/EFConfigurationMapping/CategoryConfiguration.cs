using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCategorization.Categories;

namespace ProductCategorization.EFConfigurationMapping;

internal class CategoryConfiguration : AggregateRootConfiguration<Category, int>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

        builder.Property(c => c.Name).IsRequired();

        builder.HasIndex(c => c.Name).IsUnique();
    }
}