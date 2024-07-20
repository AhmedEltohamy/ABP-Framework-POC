using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProductCategorization.Categories;

public class CategoryDataSeederContributor(IRepository<Category, int> categoryRepository, CategoryManager categoryManager) :
    IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Category, int> _categoryRepository = categoryRepository;
    private readonly CategoryManager _categoryManager = categoryManager;

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _categoryRepository.GetCountAsync() > 0) 
            return;

        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Electronics"), autoSave: true);
        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Books"), autoSave: true);
        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Clothing"), autoSave: true);
        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Home & Kitchen"), autoSave: true);
        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Health & Personal Care"), autoSave: true);
        await _categoryRepository.InsertAsync(await _categoryManager.CreateAsync("Toys & Games"), autoSave: true);
    }
}