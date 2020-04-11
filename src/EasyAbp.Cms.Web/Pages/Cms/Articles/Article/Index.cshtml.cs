using System.Threading.Tasks;

namespace EasyAbp.Cms.Web.Pages.Cms.Articles.Article
{
    public class IndexModel : CmsPageModel
    {
        public async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
