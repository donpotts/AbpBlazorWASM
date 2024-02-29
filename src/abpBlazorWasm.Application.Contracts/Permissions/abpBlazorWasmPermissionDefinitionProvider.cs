using abpBlazorWasm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpBlazorWasm.Permissions;

public class abpBlazorWasmPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(abpBlazorWasmPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(abpBlazorWasmPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<abpBlazorWasmResource>(name);
    }
}
