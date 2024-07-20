using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace ProductCategorization.Categories;

public class Category : AggregateRoot<int>
{
    public string Name { get; private set; }

    // For ORM
    private Category()
    {
    }

    private Category(string name)
    {
        Name = name;
    }

    public static Category Create(string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));
        return new Category(name);
    }
}