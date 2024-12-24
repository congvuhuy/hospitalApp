using System.Threading.Tasks;

namespace HospitalApp.Data;

public interface IHospitalAppDbSchemaMigrator
{
    Task MigrateAsync();
}
