using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abpBlazorWasm.Data;
using Volo.Abp.DependencyInjection;

namespace abpBlazorWasm.EntityFrameworkCore;

public class EntityFrameworkCoreabpBlazorWasmDbSchemaMigrator
    : IabpBlazorWasmDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreabpBlazorWasmDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the abpBlazorWasmDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<abpBlazorWasmDbContext>()
            .Database
            .MigrateAsync();
    }
}
