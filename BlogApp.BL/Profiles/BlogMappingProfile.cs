﻿using AutoMapper;
using BlogApp.BL.Dtos.BlogDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Profiles
{
    public class BlogMappingProfile :Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog,BlogDetailDto>();
            CreateMap<Blog, BlogListItemDto>();
            CreateMap<BlogCreateDto,Blog>();
            CreateMap<BlogUpdateDto,Blog>();
            CreateMap<BlogCategory,BlogCategoryDto>().ReverseMap();
        }
    }
}
