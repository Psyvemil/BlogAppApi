using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Exceptions.Common
{
    public class NegativIdException : Exception,IBaseException
    {
        public int StatusCode => StatusCodes.Status404NotFound;

        public string ErrorMessage { get;}
        public NegativIdException() : base() { ErrorMessage = "id 0 dan kicik ve 0 beraber ola bilmez"; }
        public NegativIdException(string? message) : base(message)
        {
            ErrorMessage = message;
        }

    }
}
