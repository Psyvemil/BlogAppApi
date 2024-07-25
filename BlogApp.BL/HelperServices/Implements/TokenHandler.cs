using BlogApp.BL.Dtos.UserDtos;
using BlogApp.BL.HelperServices.Interfaces;
using BlogApp.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.HelperServices.Implements
{
    internal class TokenHandler(IConfiguration _configuration) : ITokenHandler
    {
        public TokenResponsDto CreateToken(AppUser user, int expires = 60)
        {
           
            List<Claim> claims = new List<Claim>()
            {
                new Claim (ClaimTypes.NameIdentifier, user.UserName),
                new Claim (ClaimTypes.NameIdentifier,user.Id)
            };
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecurityKey"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwt = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(expires));
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
            string token = jwtHandler.WriteToken(jwt);
            return new()
            {
                Token = token,
                Expires = jwt.ValidTo,
                UserName = user.UserName,
            };
        }
    }
}
