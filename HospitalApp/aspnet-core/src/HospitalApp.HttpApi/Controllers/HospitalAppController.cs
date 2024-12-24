using HospitalApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HospitalApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HospitalAppController : AbpControllerBase
{
    protected HospitalAppController()
    {
        LocalizationResource = typeof(HospitalAppResource);
    }
}
