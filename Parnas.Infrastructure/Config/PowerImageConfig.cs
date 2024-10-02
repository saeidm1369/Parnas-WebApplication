using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Power;

namespace Parnas.Infrastructure.Config
{
    public class PowerImageConfig : IEntityTypeConfiguration<PowerImage>
    {
        public void Configure(EntityTypeBuilder<PowerImage> builder)
        {
            builder.HasOne(x => x.Power)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.PowerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
