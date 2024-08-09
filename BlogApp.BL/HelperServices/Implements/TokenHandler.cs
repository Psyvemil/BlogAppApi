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
        public TokenResponsDto CreateToken(AppUser user, double expires = 60)
        {
           
            List<Claim> claims = new List<Claim>()
            {
                 new Claim(ClaimTypes.Name, user.UserName),
                 new Claim(ClaimTypes.NameIdentifier, user.Id),
                 new Claim(ClaimTypes.Email, user.Email),
                 new Claim(ClaimTypes.GivenName, user.Name),
                 new Claim(ClaimTypes.Surname, user.Surname)
            };
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecurityKey"]));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtSecurity = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddMinutes(expires),
                credentials);
            JwtSecurityTokenHandler jwtHandler = new JwtSecurityTokenHandler();
            string token = jwtHandler.WriteToken(jwtSecurity);

            return new()
            {
                Token = token,
                Expires = jwtSecurity.ValidTo,
                Username = user.UserName,
            };
        }
    }
}
