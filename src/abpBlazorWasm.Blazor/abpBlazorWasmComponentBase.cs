using abpBlazorWasm.Localization;
using Volo.Abp.AspNetCore.Components;

namespace abpBlazorWasm.Blazor;

public abstract class abpBlazorWasmComponentBase : AbpComponentBase
{
    protected abpBlazorWasmComponentBase()
    {
        LocalizationResource = typeof(abpBlazorWasmResource);
    }
}
