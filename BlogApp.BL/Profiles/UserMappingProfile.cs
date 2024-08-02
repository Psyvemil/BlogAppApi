using AutoMapper;
using BlogApp.BL.Dtos.UserDtos;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Profiles
{
    public class UserMappingProfile :Profile
    {
        public UserMappingProfile()
        {
            CreateMap<RegisterDto, AppUser>();
            CreateMap<AppUser,AuthorDto>();
        }
    }
}
