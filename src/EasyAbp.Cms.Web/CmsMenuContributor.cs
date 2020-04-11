using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.Cms.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EasyAbp.Cms.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EasyAbp.Cms.Localization;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.Cms.Web
{
    public class CmsMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<CmsResource>>();            //Add main menu items.

            var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();
            
            var cmsMenuItem = new ApplicationMenuItem("Cms", l["Menu:Cms"]);

            if (await authorizationService.IsGrantedAsync(CmsPermissions.Categories.Default))
            {
                cmsMenuItem.AddItem(
                    new ApplicationMenuItem("Category", l["Menu:Category"], "/Cms/Categories/Category")
                );
            }

            if (await authorizationService.IsGrantedAsync(CmsPermissions.Articles.Default))
            {
                cmsMenuItem.AddItem(
                    new ApplicationMenuItem("Article", l["Menu:Article"], "/Cms/Articles/Article")
                );
            }
            
            if (!cmsMenuItem.Items.IsNullOrEmpty())
            {
                context.Menu.Items.Add(cmsMenuItem);
            }
        }
    }
}
