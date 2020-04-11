using System;
using System.Threading.Tasks;
using EasyAbp.Cms.Categories;
using EasyAbp.Cms.Categories.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.Cms.Web.Pages.Cms.Categories.Category
{
    public class EditModalModel : CmsPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateCategoryDto Category { get; set; }

        private readonly ICategoryAppService _service;

        public EditModalModel(ICategoryAppService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            Category = ObjectMapper.Map<CategoryDto, CreateUpdateCategoryDto>(dto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, Category);
            return NoContent();
        }
    }
}