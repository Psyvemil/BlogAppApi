using BlogApp.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.CommentDtos
{
    public record CommentCreateDto
    {
        public string Text { get; set; }
        
        public int? ParrentId { get; set; }
    }
    public class CommentCreateDtoValidator : AbstractValidator<CommentCreateDto>
    {
        public CommentCreateDtoValidator()
        {
                RuleFor(u=>u.Text).NotEmpty();
        }
    }

}
