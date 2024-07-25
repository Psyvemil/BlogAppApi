using AutoMapper;
using BlogApp.BL.Dtos.CategoryDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryListItemDto>().ReverseMap();
            CreateMap<Category, CategoryDetailDto>().ReverseMap();
            CreateMap<CategoryCreateDto,Category>().ReverseMap();
            CreateMap<CategoryUpdateDto, Category>().ReverseMap();


        }
    }
}
