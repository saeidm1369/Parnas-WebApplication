using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.SSD;

namespace Parnas.Infrastructure.Config
{
    public class SSDImageConfig : IEntityTypeConfiguration<SSDImage>
    {
        public void Configure(EntityTypeBuilder<SSDImage> builder)
        {
            builder.HasOne(x => x.SSD)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.SSDId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
