using EasyAbp.Cms.Categories;
using EasyAbp.Cms.Categories.Dtos;
using EasyAbp.Cms.Articles;
using EasyAbp.Cms.Articles.Dtos;
using AutoMapper;

namespace EasyAbp.Cms
{
    public class CmsApplicationAutoMapperProfile : Profile
    {
        public CmsApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateUpdateCategoryDto, Category>(MemberList.Source);
            CreateMap<Article, ArticleDto>();
            CreateMap<CreateUpdateArticleDto, Article>(MemberList.Source);
        }
    }
}
