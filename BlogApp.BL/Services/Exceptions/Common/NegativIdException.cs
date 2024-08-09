using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Exeptions.Common
{
    public class NegativIdException : Exception
    {
        public NegativIdException() : base("id 0 dan kicik ve 0 beraber ola bilmez"){}
        public NegativIdException(string? message) : base(message)
        {
        }
    }
}
