using System.Threading.Tasks;

namespace abpBlazorWasm.Data;

public interface IabpBlazorWasmDbSchemaMigrator
{
    Task MigrateAsync();
}
