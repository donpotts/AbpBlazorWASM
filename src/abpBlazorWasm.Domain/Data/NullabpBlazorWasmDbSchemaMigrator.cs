using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpBlazorWasm.Data;

/* This is used if database provider does't define
 * IabpBlazorWasmDbSchemaMigrator implementation.
 */
public class NullabpBlazorWasmDbSchemaMigrator : IabpBlazorWasmDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
