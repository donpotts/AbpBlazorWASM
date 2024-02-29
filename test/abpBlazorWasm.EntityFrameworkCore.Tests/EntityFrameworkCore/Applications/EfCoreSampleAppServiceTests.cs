using abpBlazorWasm.Samples;
using Xunit;

namespace abpBlazorWasm.EntityFrameworkCore.Applications;

[Collection(abpBlazorWasmTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<abpBlazorWasmEntityFrameworkCoreTestModule>
{

}
