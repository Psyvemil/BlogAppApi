using BlogApp.BL.HelperServices.Implements;
using BlogApp.BL.HelperServices.Interfaces;
using BlogApp.BL.Services.Implements;
using BlogApp.BL.Services.Interfaces;
using BlogApp.DAL.Repositories.Implements;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITokenHandler,TokenHandler>();
            //services.AddScoped<IBlogRepository, BlogRepository>();
            //services.AddScoped<IBlogLikeRepository, BlogLikeRepository>();
            //services.AddScoped<ICommentRepository, CommentRepository>();
        }
    }
}
