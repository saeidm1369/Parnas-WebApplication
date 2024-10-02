using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.FanCase;

namespace Parnas.Infrastructure.Config
{
    public class FanCaseImageConfig : IEntityTypeConfiguration<FanCaseImage>
    {
        public void Configure(EntityTypeBuilder<FanCaseImage> builder)
        {
            builder.HasOne(x => x.FanCase)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.FanCaseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
