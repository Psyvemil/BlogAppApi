using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Exceptions.User
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User not found") { }
        public UserNotFoundException(string message) : base(message) { }
    }
}
