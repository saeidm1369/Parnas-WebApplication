using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.CPU;

namespace Parnas.Infrastructure.Config
{
    public class CPUImageConfig : IEntityTypeConfiguration<CPUImage>
    {
        public void Configure(EntityTypeBuilder<CPUImage> builder)
        {
            builder.HasOne(x => x.CPU)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.CPUId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
