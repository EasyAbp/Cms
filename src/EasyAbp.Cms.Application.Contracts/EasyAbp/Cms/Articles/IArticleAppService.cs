using System;
using EasyAbp.Cms.Articles.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.Cms.Articles
{
    public interface IArticleAppService :
        ICrudAppService< 
            ArticleDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateArticleDto,
            CreateUpdateArticleDto>
    {

    }
}