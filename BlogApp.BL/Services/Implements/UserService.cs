using AutoMapper;
using BlogApp.BL.Dtos.UserDtos;
using BlogApp.BL.Services.Exeptions.User;
using BlogApp.BL.Services.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Implements
{
    public class UserService(UserManager<AppUser> _userManager ,IMapper _mapper) : IUserService
    {
        public async Task RegisterAsync(RegisterDto dto)
        {
            var user =_mapper.Map<AppUser>(dto);
            if(await _userManager.Users.AnyAsync(u=>dto.UserName == u.UserName|| dto.Email==u.Email))
            { throw new UserExistException(); }
            var result= await _userManager.CreateAsync(user,dto.Password);
            if(!result.Succeeded) 
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in result.Errors)
                {
                    sb.Append(item.Description+" ");
                }
                throw new RegisterFailedException(sb.ToString().TrimEnd());
            }
        }

    }
}
