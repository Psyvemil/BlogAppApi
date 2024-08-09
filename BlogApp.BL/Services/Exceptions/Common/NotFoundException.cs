using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Exceptions.Common
{
    public class NotFoundException<T> : Exception where T : class
    {
        public NotFoundException() : base(typeof(T).Name + " tapilmadi")
        {
        }

        public NotFoundException(string? message) : base(message)
        {
        }
    }
}
