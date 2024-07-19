using ProductCategorization.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductCategorization.Permissions;

public class ProductCategorizationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductCategorizationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductCategorizationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductCategorizationResource>(name);
    }
}
