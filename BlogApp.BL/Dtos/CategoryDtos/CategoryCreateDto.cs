using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BlogApp.BL.Dtos.CategoryDtos
{
    public record CategoryCreateDto
    {

        public string Name { get; set; }
        public IFormFile Logo { get; set; }
      
    }
    public class CategoryCreateDtoValidation : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryCreateDtoValidation()
        {
            RuleFor(c => c.Name)
               .NotEmpty()
                   .WithMessage("Kateqoriya adı boş ola bilməz")
               .NotNull()
                   .WithMessage("Kateqoriya adı null ola bilməz")
               .MaximumLength(64)
                   .WithMessage("Kateqoriya adı 64-dən uzun ola bilməz");
            RuleFor(c => c.Logo)
                .NotNull()
                    .WithMessage("Kateqoriya faylı null ola bilməz");
        }
    }
}
