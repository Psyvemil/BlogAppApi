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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {

        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c=>c.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(b=>b.Blog).WithMany(c=>c.Comments).HasForeignKey(c=>c.BlogId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(b => b.AppUser).WithMany(c => c.Comments).HasForeignKey(c => c.AppUserId);
            builder.HasOne(b => b.Parrent).WithMany(c => c.Children).HasForeignKey(c => c.ParrentId);

        }
    }
}
