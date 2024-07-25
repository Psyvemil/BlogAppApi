using BlogApp.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(c => c.Name).IsRequired()
                .HasMaxLength(64);
            builder.Property(c => c.Surname).IsRequired()
                .HasMaxLength(64);
            builder.Property(c=>c.ImageUrl).IsRequired(false);
        }
    }
}
