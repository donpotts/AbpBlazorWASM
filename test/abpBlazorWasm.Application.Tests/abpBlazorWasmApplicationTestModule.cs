using Volo.Abp.Modularity;

namespace abpBlazorWasm;

[DependsOn(
    typeof(abpBlazorWasmApplicationModule),
    typeof(abpBlazorWasmDomainTestModule)
)]
public class abpBlazorWasmApplicationTestModule : AbpModule
{

}
