using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Exeptions.User
{
    internal class RegisterFailedException : Exception
    {
        public RegisterFailedException() :base("user register is failed"){ }
        public RegisterFailedException(string? message) : base(message){ }
    }
}
