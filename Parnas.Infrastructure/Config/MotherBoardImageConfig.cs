using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.MotherBoard;

namespace Parnas.Infrastructure.Config
{
    public class MotherBoardImageConfig : IEntityTypeConfiguration<MotherBoardImage>
    {
        public void Configure(EntityTypeBuilder<MotherBoardImage> builder)
        {
            builder.HasOne(x => x.MotherBoard)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.MotherBoardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
