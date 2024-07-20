using Volo.Abp.Application.Dtos;

namespace ProductCategorization.Categories;

public class CategoryDto : EntityDto<int>
{
    public string Name { get; set; }
}