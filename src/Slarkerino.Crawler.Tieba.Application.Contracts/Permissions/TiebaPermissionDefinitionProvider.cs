using Slarkerino.Crawler.Tieba.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Slarkerino.Crawler.Tieba.Permissions
{
    public class TiebaPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TiebaPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(TiebaPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TiebaResource>(name);
        }
    }
}
