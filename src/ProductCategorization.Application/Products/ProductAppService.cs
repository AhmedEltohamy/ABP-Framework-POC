using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProductCategorization.Products;

public class ProductAppService(IRepository<Product, int> productRepository, ProductManager productManager) : 
    CrudAppService<Product, ProductDto, int, PagedAndSortedResultRequestDto, CreateProductDto, UpdateProductDto>(productRepository)
{
    private readonly ProductManager _productManager = productManager;

    public override async Task<ProductDto> CreateAsync(CreateProductDto input)
    {
        var product = await _productManager.CreateAsync(
            input.Name,
            input.Description,
            input.Price,
            input.CategoryIds
        );

        await Repository.InsertAsync(product);

        return ObjectMapper.Map<Product, ProductDto>(product);
    }

    public override async Task<ProductDto> UpdateAsync(int id, UpdateProductDto input)
    {
        var product = await Repository.GetAsync(id);

        await _productManager.UpdateAsync(
            product,
            input.Name,
            input.Description,
            input.Price,
            input.CategoryIds
        );

        return ObjectMapper.Map<Product, ProductDto>(product);
    }
}