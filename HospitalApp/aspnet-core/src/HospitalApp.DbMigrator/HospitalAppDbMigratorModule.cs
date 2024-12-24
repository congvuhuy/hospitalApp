using HospitalApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HospitalApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HospitalAppEntityFrameworkCoreModule),
    typeof(HospitalAppApplicationContractsModule)
    )]
public class HospitalAppDbMigratorModule : AbpModule
{
}
