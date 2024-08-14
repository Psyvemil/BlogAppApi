using BlogApp.BL.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BL.Dtos.CommentDtos
{
    public record CommentChildDto
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public AuthorDto AppUser { get; set; }
    }
}
