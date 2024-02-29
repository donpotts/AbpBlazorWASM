using abpBlazorWasm.Samples;
using Xunit;

namespace abpBlazorWasm.EntityFrameworkCore.Domains;

[Collection(abpBlazorWasmTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<abpBlazorWasmEntityFrameworkCoreTestModule>
{

}
