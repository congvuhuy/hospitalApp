using Volo.Abp.Modularity;

namespace HospitalApp;

public abstract class HospitalAppApplicationTestBase<TStartupModule> : HospitalAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
