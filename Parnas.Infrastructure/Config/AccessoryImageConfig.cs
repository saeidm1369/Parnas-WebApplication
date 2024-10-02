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
    public class AccessoryImageConfig : IEntityTypeConfiguration<GraphicCardImagr>
    {
        public void Configure(EntityTypeBuilder<GraphicCardImagr> builder)
        {
            builder.HasOne(x => x.Accessories)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.AccessoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
