using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.UserDtos
{
    public record TokenResponsDto
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public DateTime Expires { get; set; } 
    }
}
