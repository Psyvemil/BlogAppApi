using BlogApp.BL.Dtos.CategoryDtos;
using BlogApp.BL.Dtos.CommentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Services.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentListItemDto>> GetAllAsync();

        Task<CommentDetailDto> GetByIdAsync(int id);
        Task CreateAsync(int id,CommentCreateDto dto);
        Task UpdateAsync(int id, CategoryUpdateDto dto);

        Task RemoveAsync(int id);
    }
}
