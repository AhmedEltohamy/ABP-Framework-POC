using System;
using System.Collections.Generic;
using System.Text;
using ProductCategorization.Localization;
using Volo.Abp.Application.Services;

namespace ProductCategorization;

/* Inherit your application services from this class.
 */
public abstract class ProductCategorizationAppService : ApplicationService
{
    protected ProductCategorizationAppService()
    {
        LocalizationResource = typeof(ProductCategorizationResource);
    }
}
