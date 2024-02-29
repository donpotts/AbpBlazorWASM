using Volo.Abp.Modularity;

namespace abpBlazorWasm;

public abstract class abpBlazorWasmApplicationTestBase<TStartupModule> : abpBlazorWasmTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
