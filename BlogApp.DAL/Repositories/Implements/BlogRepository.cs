﻿using BlogApp.Core.Entities;
using BlogApp.DAL.Contexts;
using BlogApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implements
{
    public class BlogRepository : Repository<Blog> ,IBlogRepository
    {
        public BlogRepository(AppDbContext _context) : base(_context) { }
        
           
        
    }
}
