using Xunit;

namespace HospitalApp.EntityFrameworkCore;

[CollectionDefinition(HospitalAppTestConsts.CollectionDefinitionName)]
public class HospitalAppEntityFrameworkCoreCollection : ICollectionFixture<HospitalAppEntityFrameworkCoreFixture>
{

}
