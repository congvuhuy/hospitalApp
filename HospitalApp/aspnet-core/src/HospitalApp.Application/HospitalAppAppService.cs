using System;
using System.Collections.Generic;
using System.Text;
using HospitalApp.Localization;
using Volo.Abp.Application.Services;

namespace HospitalApp;

/* Inherit your application services from this class.
 */
public abstract class HospitalAppAppService : ApplicationService
{
    protected HospitalAppAppService()
    {
        LocalizationResource = typeof(HospitalAppResource);
    }
}
