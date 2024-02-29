using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abpBlazorWasm.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class abpBlazorWasmDbContextFactory : IDesignTimeDbContextFactory<abpBlazorWasmDbContext>
{
    public abpBlazorWasmDbContext CreateDbContext(string[] args)
    {
        abpBlazorWasmEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<abpBlazorWasmDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new abpBlazorWasmDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abpBlazorWasm.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
