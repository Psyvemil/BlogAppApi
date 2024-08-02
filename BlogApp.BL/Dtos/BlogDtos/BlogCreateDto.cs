﻿using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.BlogDtos
{
    public record BlogCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public IFormFile CoverImageFile { get; set; }
        public IEnumerable<int> CategoryIds { get; set; }
    }
    public class BlogCreateDtoValidator : AbstractValidator<BlogCreateDto>
    {
        public BlogCreateDtoValidator()
        {
            RuleFor(b => b.Title)
                .MaximumLength(255);
            RuleFor(b => b.Description)
                .NotEmpty()
                .NotNull();
            RuleFor(b => b.CoverImageUrl)
                .NotEmpty()
                .NotNull();
            RuleForEach(b => b.CategoryIds)
                .GreaterThan(0)
                .NotEmpty();
            RuleFor(b => b.CategoryIds)
                .Must(b => IsDistinct(b))
                .WithMessage("Idler tekrarlana bilmez");
           
        }
        private bool IsDistinct(IEnumerable<int> ids)
        {
            var encounteredIds = new HashSet<int>();

            foreach (var id in ids)
            {
                if (encounteredIds.Contains(id)) return false;
                encounteredIds.Add(id);
            }

            return true;
        }
    }
}