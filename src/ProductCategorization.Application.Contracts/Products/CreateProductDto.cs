using ProductCategorization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductCategorization.Products;

public class CreateProductDto
{
    [Required]
    [StringLength(ProductConsts.MaxNameLength, MinimumLength = ProductConsts.MinNameLength)]
    public string Name { get; set; }
    
    public string? Description { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "The price must be a positive value.")]
    public decimal Price { get; set; }

    [MinimumCount(1, ErrorMessage = "The CategoryIds field must contain at least one element.")]
    public List<int> CategoryIds { get; set; }
}