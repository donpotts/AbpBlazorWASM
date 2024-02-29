using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abpBlazorWasm.Blazor;

[Dependency(ReplaceServices = true)]
public class abpBlazorWasmBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "abpBlazorWasm";
}
