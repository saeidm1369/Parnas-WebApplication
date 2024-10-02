using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Gaming;

namespace Parnas.Infrastructure.Config
{
    public class GamingImageConfig : IEntityTypeConfiguration<GamingImage>
    {
        public void Configure(EntityTypeBuilder<GamingImage> builder)
        {
            builder.HasOne(x => x.Gaming)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.GamingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
