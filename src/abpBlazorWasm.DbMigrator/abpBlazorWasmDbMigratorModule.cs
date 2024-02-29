using abpBlazorWasm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace abpBlazorWasm.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(abpBlazorWasmEntityFrameworkCoreModule),
    typeof(abpBlazorWasmApplicationContractsModule)
    )]
public class abpBlazorWasmDbMigratorModule : AbpModule
{
}
