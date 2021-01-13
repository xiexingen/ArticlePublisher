using XXG.ArticlePublisher.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XXG.ArticlePublisher.Permissions
{
    public class ArticlePublisherPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ArticlePublisherPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ArticlePublisherPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ArticlePublisherResource>(name);
        }
    }
}
