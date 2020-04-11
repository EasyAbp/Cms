using System;
using System.ComponentModel;
namespace EasyAbp.Cms.Categories.Dtos
{
    public class CreateUpdateCategoryDto
    {
        [DisplayName("CategoryName")]
        public string Name { get; set; }

        [DisplayName("CategoryShortName")]
        public string ShortName { get; set; }

        [DisplayName("CategoryDescription")]
        public string Description { get; set; }
    }
}