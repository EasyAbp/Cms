using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.Cms
{
    [DependsOn(
        typeof(CmsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CmsConsoleApiClientModule : AbpModule
    {
        
    }
}
