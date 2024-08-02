using AutoMapper;
using BlogApp.BL.Dtos.BlogDtos;
using BlogApp.BL.Dtos.CategoryDtos;
using BlogApp.BL.Services.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Implements
{
    public class BlogService(IBlogRepository _repo,IMapper _mapper ,IHttpContextAccessor _context) : IBlogService
    {
        readonly string userId = _context.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        public async Task CreateAsync(BlogCreateDto dto)
        {
            Blog blog = _mapper.Map<Blog>(dto);
        }

        public async Task<IEnumerable<BlogListItemDto>> GetAllAsync()
        {
            //var dto = new List<BlogListItemDto>();
            //var entity = _repo.GetAll("AppUser", "BlogCategories", "BlogCategories.Category");
            //List<Category> categories = new();

            //foreach (var item in entity)
            //{
            //    categories.Clear();
            //    foreach (var category in item.BlogCategories)
            //    {
            //        categories.Add(category.Category);
            //    }
            //    var dtoItem = _mapper.Map<BlogListItemDto>(item);
            //    dtoItem.Categories = _mapper.Map<IEnumerable<CategoryListItemDto>>(categories);

            //    dto.Add(dtoItem);
            //}
            //return dto;
            var entity = _repo.GetAll("AppUser", "BlogCategories", "BlogCategories.Category");
            return _mapper.Map<IEnumerable<BlogListItemDto>>(entity);
        }

        public Task<BlogDetailDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, BlogUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
