using System;
using System.Collections.Generic;
using System.Text;
using abpBlazorWasm.Localization;
using Volo.Abp.Application.Services;

namespace abpBlazorWasm;

/* Inherit your application services from this class.
 */
public abstract class abpBlazorWasmAppService : ApplicationService
{
    protected abpBlazorWasmAppService()
    {
        LocalizationResource = typeof(abpBlazorWasmResource);
    }
}
