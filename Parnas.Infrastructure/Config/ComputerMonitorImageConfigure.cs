using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.ComputerMonitor;

namespace Parnas.Infrastructure.Config
{
    public class ComputerMonitorImageConfigure : IEntityTypeConfiguration<ComputerMonitorImage>
    {
        public void Configure(EntityTypeBuilder<ComputerMonitorImage> builder)
        {
            builder.HasOne(x => x.ComputerMonitor)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.ComputerMonitorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
