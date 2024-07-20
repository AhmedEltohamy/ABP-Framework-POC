using ProductCategorization.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace ProductCategorization.Products;

public sealed class ProductManager(IRepository<Product, int> productRepository, IRepository<Category, int> categoryRepository) : DomainService
{
    private readonly IRepository<Product, int> _productRepository = productRepository;
    private readonly IRepository<Category, int> _categoryRepository = categoryRepository;

    public async Task<Product> CreateAsync(string name, string? description, decimal price, List<int> categoryIds)
    {
        await ValidateNameExistence(name);

        return Product.Create(
            name,
            description,
            price,
            await GetCategoriesAsync(categoryIds)
        );
    }

    public async Task UpdateAsync(Product product, string name, string? description, decimal price, List<int> categoryIds)
    {
        await ValidateNameExistence(name, product.Id);

        product.Update(
            name,
            description,
            price,
            await GetCategoriesAsync(categoryIds)
        );
    }

    private async Task ValidateNameExistence(string name, int? id = null)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));

        var existingProduct = await _productRepository.FindAsync(p => p.Name == name);
        if (existingProduct is not null && (!id.HasValue || existingProduct.Id != id.Value))
            throw new BusinessException(message: $"There is already an product with the same name: {name}.");
    }

    private async Task<List<Category>> GetCategoriesAsync(List<int> categoryIds)
    {
        ArgumentNullException.ThrowIfNull(categoryIds);

        if (categoryIds.Count == 0)
            throw new BusinessException("At least one category is required.");

        var categories = await _categoryRepository.GetListAsync(c => categoryIds.Any(id => id == c.Id));
        if (categories.Count != categoryIds.Count)
            throw new EntityNotFoundException("Some categories were not found.");

        return categories;
    }
}