using Volo.Abp.Modularity;

namespace EasyAbp.Cms
{
    [DependsOn(
        typeof(CmsDomainSharedModule)
        )]
    public class CmsDomainModule : AbpModule
    {

    }
}
