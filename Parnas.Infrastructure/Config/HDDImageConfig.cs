using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.HDD;

namespace Parnas.Infrastructure.Config
{
    public class HDDImageConfig : IEntityTypeConfiguration<HDDImage>
    {
        public void Configure(EntityTypeBuilder<HDDImage> builder)
        {
            builder.HasOne(x => x.HDD)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.HDDId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
