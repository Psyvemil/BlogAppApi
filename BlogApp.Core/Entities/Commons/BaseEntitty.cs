﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities.Commons
{
    public class BaseEntitty
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
