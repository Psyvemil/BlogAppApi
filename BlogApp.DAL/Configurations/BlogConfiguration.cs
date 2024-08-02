using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(255);
            builder.Property(b => b.Description)
                .IsRequired();
            builder.Property(b => b.CoverImageUrl)
                .IsRequired();
            builder.Property(b => b.ViewerCount)
                .HasDefaultValue(0);
            builder.Property(b => b.CreatedTime)
                .HasDefaultValue(DateTime.Now);
            builder.HasOne(b => b.AppUser)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.AppUserId);
        }
    }
}
