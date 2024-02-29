using Volo.Abp.Modularity;

namespace abpBlazorWasm;

[DependsOn(
    typeof(abpBlazorWasmDomainModule),
    typeof(abpBlazorWasmTestBaseModule)
)]
public class abpBlazorWasmDomainTestModule : AbpModule
{

}
