using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Exeptions.Common
{
    public class NegativIdExeption : Exception
    {
        public NegativIdExeption() : base("id 0 dan kicik ve 0 beraber ola bilmez"){}
        public NegativIdExeption(string? message) : base(message)
        {
        }
    }
}
