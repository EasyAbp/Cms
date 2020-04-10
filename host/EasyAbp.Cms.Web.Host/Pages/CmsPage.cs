using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.Cms.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.Cms.Pages
{
    public abstract class CmsPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<CmsResource> L { get; set; }
    }
}
