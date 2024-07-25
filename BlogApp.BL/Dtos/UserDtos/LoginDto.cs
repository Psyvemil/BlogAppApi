using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.UserDtos
{
    public record LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class LoginValidator : AbstractValidator<LoginDto>
    {
        public LoginValidator()
        {
            RuleFor(u => u.UserName)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(3)
                    .MaximumLength(45);
            RuleFor(u => u.Password)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(6);
        }
    }
}
