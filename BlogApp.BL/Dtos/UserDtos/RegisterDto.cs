using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.UserDtos
{
    public record RegisterDto
    {
        public string Name  { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }

    }
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator() 
        {
            RuleFor(u=>u.Name)
                .MinimumLength(2)
                .MaximumLength(25)
                .NotNull()
                .NotEmpty();
            RuleFor(u => u.Surname)
             .MinimumLength(2)
             .MaximumLength(25)
             .NotNull()
             .NotEmpty();
            RuleFor(u => u.Email)
       .NotEmpty()
       .NotNull()
       .Must(u =>
       {
           Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
           var result = regex.Match(u);
           return result.Success;
       })
           .WithMessage("Please enter valid email");
            RuleFor(u => u.UserName)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(45);
            RuleFor(u => u.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6);
            RuleFor(u => u)
                .Must(u => u.Password == u.ConfirmPassword)
                    .WithMessage("Password must be equal to ConfirmPassword");

        }
    }

}
