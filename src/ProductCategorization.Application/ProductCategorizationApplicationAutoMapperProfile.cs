using AutoMapper;
using ProductCategorization.Categories;
using ProductCategorization.Products;

namespace ProductCategorization;

public class ProductCategorizationApplicationAutoMapperProfile : Profile
{
    public ProductCategorizationApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Category, CategoryDto>();
    }
}