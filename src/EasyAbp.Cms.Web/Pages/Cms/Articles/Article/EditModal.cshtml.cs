using System;
using System.Threading.Tasks;
using EasyAbp.Cms.Articles;
using EasyAbp.Cms.Articles.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.Cms.Web.Pages.Cms.Articles.Article
{
    public class EditModalModel : CmsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateArticleDto Article { get; set; }

        private readonly IArticleAppService _service;

        public EditModalModel(IArticleAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            Article = ObjectMapper.Map<ArticleDto, CreateUpdateArticleDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, Article);
            return NoContent();
        }
    }
}