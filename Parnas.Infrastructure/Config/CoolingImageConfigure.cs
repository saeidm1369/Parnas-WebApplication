using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Cooling;

namespace Parnas.Infrastructure.Config
{
    public class CoolingImageConfigure : IEntityTypeConfiguration<CoolingImage>
    {
        public void Configure(EntityTypeBuilder<CoolingImage> builder)
        {
            builder.HasOne(x => x.Cooling)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.CoolingId)
                .OnDelete(DeleteBehavior.Cascade);
        }  
    }
}
