using Volo.Abp.Modularity;

namespace HospitalApp;

/* Inherit from this class for your domain layer tests. */
public abstract class HospitalAppDomainTestBase<TStartupModule> : HospitalAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
