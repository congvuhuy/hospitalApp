using HospitalApp.Samples;
using Xunit;

namespace HospitalApp.EntityFrameworkCore.Domains;

[Collection(HospitalAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HospitalAppEntityFrameworkCoreTestModule>
{

}
