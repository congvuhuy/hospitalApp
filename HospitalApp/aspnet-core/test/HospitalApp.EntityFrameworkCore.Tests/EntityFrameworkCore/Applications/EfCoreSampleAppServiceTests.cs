using HospitalApp.Samples;
using Xunit;

namespace HospitalApp.EntityFrameworkCore.Applications;

[Collection(HospitalAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HospitalAppEntityFrameworkCoreTestModule>
{

}
