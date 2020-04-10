using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.Cms.MongoDB
{
    public static class CmsMongoDbContextExtensions
    {
        public static void ConfigureCms(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new CmsMongoModelBuilderConfigurationOptions(
                CmsDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}