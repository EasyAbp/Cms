using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace EasyAbp.Cms.MongoDB
{
    public class CmsMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public CmsMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}