using Xunit;

namespace abpBlazorWasm.EntityFrameworkCore;

[CollectionDefinition(abpBlazorWasmTestConsts.CollectionDefinitionName)]
public class abpBlazorWasmEntityFrameworkCoreCollection : ICollectionFixture<abpBlazorWasmEntityFrameworkCoreFixture>
{

}
