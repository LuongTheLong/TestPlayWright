using TestPlayWright.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestPlayWright.Permissions;

public class TestPlayWrightPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestPlayWrightPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestPlayWrightPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestPlayWrightResource>(name);
    }
}
