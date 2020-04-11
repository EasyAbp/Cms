using System;
using System.Threading.Tasks;
using EasyAbp.Cms.Articles;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace EasyAbp.Cms.EntityFrameworkCore.Articles
{
    public class ArticleRepositoryTests : CmsEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Article, Guid> _articleRepository;

        public ArticleRepositoryTests()
        {
            _articleRepository = GetRequiredService<IRepository<Article, Guid>>();
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
