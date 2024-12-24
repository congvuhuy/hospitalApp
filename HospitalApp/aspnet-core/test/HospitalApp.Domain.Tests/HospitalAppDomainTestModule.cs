using Volo.Abp.Modularity;

namespace HospitalApp;

[DependsOn(
    typeof(HospitalAppDomainModule),
    typeof(HospitalAppTestBaseModule)
)]
public class HospitalAppDomainTestModule : AbpModule
{

}
