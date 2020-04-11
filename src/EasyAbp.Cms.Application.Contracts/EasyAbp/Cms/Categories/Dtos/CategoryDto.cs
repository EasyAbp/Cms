using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.Cms.Categories.Dtos
{
    public class CategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Description { get; set; }
    }
}