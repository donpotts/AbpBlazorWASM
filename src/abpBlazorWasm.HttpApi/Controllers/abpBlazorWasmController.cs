using abpBlazorWasm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpBlazorWasm.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class abpBlazorWasmController : AbpControllerBase
{
    protected abpBlazorWasmController()
    {
        LocalizationResource = typeof(abpBlazorWasmResource);
    }
}
