using ProductCategorization.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductCategorization.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductCategorizationController : AbpControllerBase
{
    protected ProductCategorizationController()
    {
        LocalizationResource = typeof(ProductCategorizationResource);
    }
}
