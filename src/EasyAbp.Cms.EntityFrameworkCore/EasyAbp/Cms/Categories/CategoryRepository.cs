using System;
using EasyAbp.Cms.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.Cms.Categories
{
    public class CategoryRepository : EfCoreRepository<CmsDbContext, Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<CmsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}