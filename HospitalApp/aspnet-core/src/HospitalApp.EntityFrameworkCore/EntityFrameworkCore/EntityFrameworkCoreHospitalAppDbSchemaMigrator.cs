using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HospitalApp.Data;
using Volo.Abp.DependencyInjection;

namespace HospitalApp.EntityFrameworkCore;

public class EntityFrameworkCoreHospitalAppDbSchemaMigrator
    : IHospitalAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHospitalAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the HospitalAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HospitalAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
