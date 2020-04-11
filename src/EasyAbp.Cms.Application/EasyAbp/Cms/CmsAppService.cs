using EasyAbp.Cms.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.Cms
{
    public abstract class CmsAppService : ApplicationService
    {
        protected CmsAppService()
        {
            LocalizationResource = typeof(CmsResource);
            ObjectMapperContext = typeof(CmsApplicationModule);
        }
    }
}
