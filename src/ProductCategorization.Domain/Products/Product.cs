using ProductCategorization.Categories;
using System;
using System.Collections.Generic;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace ProductCategorization.Products;

public class Product : AggregateRoot<int>
{
    public string Name { get; private set; }

    public string? Description { get; private set; }

    public decimal Price { get; private set; }

    public List<Category> Categories { get; private set; } = [];

    // For ORM
    private Product()
    {
    }

    private Product(string name, string? description, decimal price, List<Category> categories)
    {
        Name = name;
        Description = description;
        Price = price;
        Categories = categories;
    }

    internal static Product Create(string name, string? description, decimal price, List<Category> categories)
    {
        name = ValidateName(name);
        description = ValidateDescription(description);
        ValidatePrice(price);
        return new Product(name, description, price, categories);
    }

    internal void Update(string name, string? description, decimal price, List<Category> categories)
    {
        Name = ValidateName(name);
        Description = ValidateDescription(description);
        ValidatePrice(price);
        Price = price;
        Categories = categories;
    }

    private static string ValidateName(string name) =>
        Check.NotNullOrWhiteSpace(
            name,
            nameof(name),
            ProductConsts.MaxNameLength,
            ProductConsts.MinNameLength
        );

    private static string? ValidateDescription(string? description) =>
        description.IsNullOrWhiteSpace() ? null : description;

    private static void ValidatePrice(decimal price)
    {
        if (price <= 0)
            throw new BusinessException("The price must be a positive value.");
    }

}