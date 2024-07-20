using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ProductCategorization.Attributes;

public class MinimumCountAttribute(int minCount) : ValidationAttribute
{
    private readonly int _minCount = minCount;

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IList list && list.Count >= _minCount)
        {
            return ValidationResult.Success;
        }

        return new ValidationResult($"The field {validationContext.DisplayName} must contain at least {_minCount} element(s).");
    }
}