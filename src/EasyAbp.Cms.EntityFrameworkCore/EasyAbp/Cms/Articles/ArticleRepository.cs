using System;
using EasyAbp.Cms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Cms.Articles
{
    public class ArticleRepository : EfCoreRepository<CmsDbContext, Article, Guid>, IArticleRepository
    {
        public ArticleRepository(IDbContextProvider<CmsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}