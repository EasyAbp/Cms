using Volo.Abp.Modularity;

namespace EasyAbp.Cms
{
    [DependsOn(
        typeof(CmsApplicationModule),
        typeof(CmsDomainTestModule)
        )]
    public class CmsApplicationTestModule : AbpModule
    {

    }
}
