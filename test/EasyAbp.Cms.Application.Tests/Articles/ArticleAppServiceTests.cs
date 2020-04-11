using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace EasyAbp.Cms.Articles
{
    public class ArticleAppServiceTests : CmsApplicationTestBase
    {
        private readonly IArticleAppService _articleAppService;

        public ArticleAppServiceTests()
        {
            _articleAppService = GetRequiredService<IArticleAppService>();
        }

        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
