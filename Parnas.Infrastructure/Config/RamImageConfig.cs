using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Ram;

namespace Parnas.Infrastructure.Config
{
    public class RamImageConfig : IEntityTypeConfiguration<RamImage>
    {
        public void Configure(EntityTypeBuilder<RamImage> builder)
        {
            builder.HasOne(x => x.Ram)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.RamId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
