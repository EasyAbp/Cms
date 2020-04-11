using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.Cms.EntityFrameworkCore
{
    public class CmsModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public CmsModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}