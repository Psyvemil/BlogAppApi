using AutoMapper;
using BlogApp.BL.Dtos.UserDtos;
using BlogApp.BL.Exceptions.User;
using BlogApp.BL.HelperServices.Interfaces;

using BlogApp.BL.Services.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Implements
{
    public class UserService(UserManager<AppUser> _userManager ,IMapper _mapper,ITokenHandler _token) : IUserService
    {
        public async Task<TokenResponsDto> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null ) {throw new UserNotFoundException(); }
            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            if (!result) {throw new LoginFailedException(); }
           
            return _token.CreateToken(user);
        }

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
