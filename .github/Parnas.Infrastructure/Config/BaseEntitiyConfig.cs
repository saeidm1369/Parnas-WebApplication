using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Infrastructure.Config
{
    public class BaseEntitiyConfig : IEntityTypeConfiguration<BaseEntity<string>>
    {
        public void Configure(EntityTypeBuilder<BaseEntity<string>> builder)
        {
            builder.HasQueryFilter(b => !b.IsDelete);

            builder.Property(b => b.Title).HasMaxLength(50);
        }
    }
}
