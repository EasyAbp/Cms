using System;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.Cms.Categories
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
    }
}