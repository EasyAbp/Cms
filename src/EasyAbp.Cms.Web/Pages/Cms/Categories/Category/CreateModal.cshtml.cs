using System.Threading.Tasks;
using EasyAbp.Cms.Categories;
using EasyAbp.Cms.Categories.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.Cms.Web.Pages.Cms.Categories.Category
{
    public class CreateModalModel : CmsPageModel
    {
        [BindProperty]
        public CreateUpdateCategoryDto Category { get; set; }

        private readonly ICategoryAppService _service;

        public CreateModalModel(ICategoryAppService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(Category);
            return NoContent();
        }
    }
}