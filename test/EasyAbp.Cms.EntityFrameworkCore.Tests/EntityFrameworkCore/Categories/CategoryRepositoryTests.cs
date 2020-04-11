using System;
using System.Threading.Tasks;
using EasyAbp.Cms.Categories;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace EasyAbp.Cms.EntityFrameworkCore.Categories
{
    public class CategoryRepositoryTests : CmsEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoryRepositoryTests()
        {
            _categoryRepository = GetRequiredService<IRepository<Category, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
