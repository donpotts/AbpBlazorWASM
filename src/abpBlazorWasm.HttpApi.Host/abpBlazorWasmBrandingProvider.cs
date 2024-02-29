using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abpBlazorWasm;

[Dependency(ReplaceServices = true)]
public class abpBlazorWasmBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "abpBlazorWasm";
}
