using AutoMapper;
using BtkAkademiAIblog.WebApi.Dtos.ArticleDtos;
using BtkAkademiAIblog.WebApi.Entities;


namespace BtkAkademiAIblog.WebApi.Mapping
{
  public class GeneralMapping : Profile
  {
    public GeneralMapping()
    {
      CreateMap<Article, ResultArticleWithCategoryDto>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category != null ? src.Category.CategoryName : "Kategorisiz"));
      CreateMap<Article, CreatArticleDto>().ReverseMap();
      CreateMap<Article, UpdateArticleDto>().ReverseMap();
      CreateMap<Article, GetArticleByIdDto>().ReverseMap();


    }
  }
}