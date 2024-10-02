using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.GraphicCard;

namespace Parnas.Infrastructure.Config
{
    public class GraphicCardImageConfig : IEntityTypeConfiguration<GraphicCardImage>
    {
        public void Configure(EntityTypeBuilder<GraphicCardImage> builder)
        {
            builder.HasOne(x => x.GraphicCard)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.GraphicCardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
