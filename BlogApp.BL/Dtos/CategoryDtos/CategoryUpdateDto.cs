using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.CategoryDtos
{
    public record CategoryUpdateDto
    {
        public string Name { get; set; }
        public IFormFile? Logo { get; set; }

    }
    public class CategoryUpdateDtoValidation : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidation() 
        {
            RuleFor(c => c.Name)
               .NotEmpty()
                   .WithMessage("Kateqoriya adı boş ola bilməz")
               .NotNull()
                   .WithMessage("Kateqoriya adı null ola bilməz")
               .MaximumLength(64)
                   .WithMessage("Kateqoriya adı 64-dən uzun ola bilməz");
           
        }
    }
    
}
