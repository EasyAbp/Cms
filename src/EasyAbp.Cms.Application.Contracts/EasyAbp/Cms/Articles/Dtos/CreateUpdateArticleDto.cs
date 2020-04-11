using System;
using System.ComponentModel;
namespace EasyAbp.Cms.Articles.Dtos
{
    public class CreateUpdateArticleDto
    {
        [DisplayName("ArticleTitle")]
        public string Title { get; set; }

        [DisplayName("ArticleContent")]
        public string Content { get; set; }

        [DisplayName("ArticleReadCount")]
        public int ReadCount { get; set; }
    }
}