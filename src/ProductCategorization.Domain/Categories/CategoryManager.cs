using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace ProductCategorization.Categories;

public class CategoryManager(IRepository<Category, int> categoryRepository) : IDomainService
{
    private readonly IRepository<Category, int> _categoryRepository = categoryRepository;

    public async Task<Category> CreateAsync(string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));

        var existingCategory = await _categoryRepository.FindAsync(c => c.Name == name);
        if (existingCategory is not null)
            throw new BusinessException($"There is already an category with the same name: {name}.");

        return Category.Create(name);
    }
}