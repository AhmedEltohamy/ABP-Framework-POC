using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductCategorization.EFConfigurationMapping;

internal class AggregateRootConfiguration<T, TKey> : IEntityTypeConfiguration<T> where T : AggregateRoot<TKey>
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ConfigureByConvention();
    }
}