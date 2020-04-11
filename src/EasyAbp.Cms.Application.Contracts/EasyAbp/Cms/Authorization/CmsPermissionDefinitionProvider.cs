using EasyAbp.Cms.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.Cms.Authorization
{
    public class CmsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var moduleGroup = context.AddGroup(CmsPermissions.GroupName, L("Permission:Cms"));
            
            var categories = moduleGroup.AddPermission(CmsPermissions.Categories.Default, L("Permission:Category"));
            categories.AddChild(CmsPermissions.Categories.Create, L("Permission:Create"));
            categories.AddChild(CmsPermissions.Categories.Update, L("Permission:Update"));
            categories.AddChild(CmsPermissions.Categories.Delete, L("Permission:Delete"));
            
            var articles = moduleGroup.AddPermission(CmsPermissions.Articles.Default, L("Permission:Article"));
            articles.AddChild(CmsPermissions.Articles.Create, L("Permission:Create"));
            articles.AddChild(CmsPermissions.Articles.Update, L("Permission:Update"));
            articles.AddChild(CmsPermissions.Articles.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CmsResource>(name);
        }
    }
}