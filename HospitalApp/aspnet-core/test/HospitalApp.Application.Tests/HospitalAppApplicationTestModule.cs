using Volo.Abp.Modularity;

namespace HospitalApp;

[DependsOn(
    typeof(HospitalAppApplicationModule),
    typeof(HospitalAppDomainTestModule)
)]
public class HospitalAppApplicationTestModule : AbpModule
{

}
