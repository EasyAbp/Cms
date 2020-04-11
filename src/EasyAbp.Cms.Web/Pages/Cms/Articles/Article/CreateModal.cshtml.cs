using System.Threading.Tasks;
using EasyAbp.Cms.Articles;
using EasyAbp.Cms.Articles.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.Cms.Web.Pages.Cms.Articles.Article
{
    public class CreateModalModel : CmsPageModel
    {
        [BindProperty]
        public CreateUpdateArticleDto Article { get; set; }

        private readonly IArticleAppService _service;

        public CreateModalModel(IArticleAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(Article);
            return NoContent();
        }
    }
}