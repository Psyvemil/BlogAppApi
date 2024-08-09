using BlogApp.BL.Dtos.UserDtos;
using BlogApp.Core.Entities;

namespace BlogApp.BL.HelperServices.Interfaces
{
    public interface ITokenHandler                                                    //token service or handler
    {
        TokenResponsDto CreateToken(AppUser user, double expires = 60);
      
        
    }
}
