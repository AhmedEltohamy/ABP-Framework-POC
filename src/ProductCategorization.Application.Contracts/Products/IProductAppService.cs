using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductCategorization.Products;

public interface IProductAppService : ICrudAppService<ProductDto, int, PagedAndSortedResultRequestDto, CreateProductDto, UpdateProductDto>
{
}