using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.Cms.Articles.Dtos
{
    public class ArticleDto : EntityDto<Guid>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int ReadCount { get; set; }
    }
}