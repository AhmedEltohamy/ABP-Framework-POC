using ProductCategorization.Samples;
using Xunit;

namespace ProductCategorization.EntityFrameworkCore.Applications;

[Collection(ProductCategorizationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProductCategorizationEntityFrameworkCoreTestModule>
{

}
