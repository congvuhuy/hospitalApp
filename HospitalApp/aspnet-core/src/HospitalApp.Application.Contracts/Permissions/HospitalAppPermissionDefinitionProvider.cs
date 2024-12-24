using HospitalApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HospitalApp.Permissions;

public class HospitalAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HospitalAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HospitalAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HospitalAppResource>(name);
    }
}
