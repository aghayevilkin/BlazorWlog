using AutoMapper;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewsCategory, NewsCategoryDTO>().ReverseMap();
            CreateMap<Subscribe, SubscribeDTO>().ReverseMap();
            CreateMap<NewsComment, NewsCommentDTO>().ReverseMap();
            CreateMap<NewsSubCategory, NewsSubCategoryDTO>().ReverseMap();
            CreateMap<News, NewsDTO>().ReverseMap();
            CreateMap<NewsImage, NewsImageDTO>().ReverseMap();

        }
    }
}
