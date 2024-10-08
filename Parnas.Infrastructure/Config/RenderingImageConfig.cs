using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Gaming;
using static Parnas.Domain.Entities.Rendering;

namespace Parnas.Infrastructure.Config
{
    public class RenderingImageConfig : IEntityTypeConfiguration<RenderingImage>
    {
        public void Configure(EntityTypeBuilder<RenderingImage> builder)
        {
            builder.HasOne(x => x.Rendering)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.RenderingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
