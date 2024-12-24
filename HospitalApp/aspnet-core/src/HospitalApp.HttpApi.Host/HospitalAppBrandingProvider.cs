using Microsoft.Extensions.Localization;
using HospitalApp.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HospitalApp;

[Dependency(ReplaceServices = true)]
public class HospitalAppBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HospitalAppResource> _localizer;

    public HospitalAppBrandingProvider(IStringLocalizer<HospitalAppResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
