using ProductCategorization.Samples;
using Xunit;

namespace ProductCategorization.EntityFrameworkCore.Domains;

[Collection(ProductCategorizationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProductCategorizationEntityFrameworkCoreTestModule>
{

}
