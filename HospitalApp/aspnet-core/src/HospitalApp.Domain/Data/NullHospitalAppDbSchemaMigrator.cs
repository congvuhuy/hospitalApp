using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HospitalApp.Data;

/* This is used if database provider does't define
 * IHospitalAppDbSchemaMigrator implementation.
 */
public class NullHospitalAppDbSchemaMigrator : IHospitalAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
