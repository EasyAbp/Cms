using System;
using EasyAbp.Cms.Articles.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.Cms.Articles
{
    public class ArticleAppService : CrudAppService<Article, ArticleDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateArticleDto, CreateUpdateArticleDto>,
        IArticleAppService
    {
        private readonly IArticleRepository _repository;

        public ArticleAppService(IArticleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}