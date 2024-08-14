﻿using AutoMapper;
using BlogApp.BL.Dtos.CategoryDtos;
using BlogApp.BL.Dtos.CommentDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Profiles
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, CommentListItemDto>().ReverseMap();
            CreateMap<Comment, CommentDetailDto>().ReverseMap();
            CreateMap<CommentChildDto, Comment>().ReverseMap();
            CreateMap<CommentCreateDto, Comment>().ReverseMap();
            CreateMap<CommentUpdateDto, Comment>().ReverseMap();
        }
    }
}
