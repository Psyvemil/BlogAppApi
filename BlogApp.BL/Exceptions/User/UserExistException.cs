using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Exceptions.User
{
    public class UserExistException : Exception
    {
        public UserExistException() : base("username or email alredy existed")
        { }
        public UserExistException(string? message) : base(message)
        { }

    }
}
