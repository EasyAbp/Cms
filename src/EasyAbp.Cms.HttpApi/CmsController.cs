using EasyAbp.Cms.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.Cms
{
    public abstract class CmsController : AbpController
    {
        protected CmsController()
        {
            LocalizationResource = typeof(CmsResource);
        }
    }
}
