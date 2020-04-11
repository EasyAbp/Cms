using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using EasyAbp.Cms.Categories;
using EasyAbp.Cms.Articles;

namespace EasyAbp.Cms.EntityFrameworkCore
{
    [ConnectionStringName(CmsDbProperties.ConnectionStringName)]
    public class CmsDbContext : AbpDbContext<CmsDbContext>, ICmsDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        public CmsDbContext(DbContextOptions<CmsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureCms();
        }
    }
}
