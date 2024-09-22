using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parnas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Infrastructure.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(c => c.ParentId).IsRequired(false);

            builder.HasMany(c => c.SubCategories).WithOne(c => c.ParentCategory)
                .HasForeignKey(c => c.ParentId);
        }
    }
}
