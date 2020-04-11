using EasyAbp.Cms.Categories.Dtos;
using EasyAbp.Cms.Articles.Dtos;
using AutoMapper;

namespace EasyAbp.Cms.Web
{
    public class CmsWebAutoMapperProfile : Profile
    {
        public CmsWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<CategoryDto, CreateUpdateCategoryDto>();
            CreateMap<ArticleDto, CreateUpdateArticleDto>();
        }
    }
}
