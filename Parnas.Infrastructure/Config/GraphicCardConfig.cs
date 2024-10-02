using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parnas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Infrastructure.Config
{
    public class GraphicCardConfig : IEntityTypeConfiguration<GraphicCard>
    {
        public void Configure(EntityTypeBuilder<GraphicCard> builder)
        {
            builder.HasOne(x => x.Category).WithMany(x => x.GraphicCards)
                .HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(x => x.Id);

            builder.HasQueryFilter(x => !x.IsDelete);
            builder.Property(x => x.IsDelete).HasDefaultValue(false);
        }
    }
}
