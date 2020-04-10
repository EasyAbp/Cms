using EasyAbp.Cms.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Cms.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CmsPageModel : AbpPageModel
    {
        protected CmsPageModel()
        {
            LocalizationResourceType = typeof(CmsResource);
            ObjectMapperContext = typeof(CmsWebModule);
        }
    }
}