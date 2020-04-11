using System;
using EasyAbp.Cms.Categories.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.Cms.Categories
{
    public interface ICategoryAppService :
        ICrudAppService< 
            CategoryDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateCategoryDto,
            CreateUpdateCategoryDto>
    {

    }
}