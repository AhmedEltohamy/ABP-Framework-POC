using ProductCategorization.Categories;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace ProductCategorization.Products;

public class ProductDto : EntityDto<int>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<CategoryDto> Categories { get; set; } = [];
}