using System;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.Cms.Articles
{
    public interface IArticleRepository : IRepository<Article, Guid>
    {
    }
}