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
    internal class BlogCategoryConfigutarion : IEntityTypeConfiguration<BlogCategory>
    {
        public void Configure(EntityTypeBuilder<BlogCategory> builder)
        {
            builder.HasOne(b => b.Blog)
                .WithMany(b => b.BlogCategories).HasForeignKey(b=>b.BlogId);
            builder.HasOne(b => b.Category)
            .WithMany(b => b.BlogCategories).HasForeignKey(b => b.CategoryId);
            builder.Ignore(b=>b.IsDeleted);
        }
    }
}
