using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Exceptions.User
{
    public class LoginFailedException : Exception
    {
        public LoginFailedException():base("username or password incorrect") { }
        public LoginFailedException(string message) : base(message) { }
    }
}
