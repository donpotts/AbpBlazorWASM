using Volo.Abp.Modularity;

namespace abpBlazorWasm;

/* Inherit from this class for your domain layer tests. */
public abstract class abpBlazorWasmDomainTestBase<TStartupModule> : abpBlazorWasmTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
