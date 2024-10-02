using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Case;

namespace Parnas.Infrastructure.Config
{
    public class CaseImageConfig : IEntityTypeConfiguration<CaseImage>
    {
        public void Configure(EntityTypeBuilder<CaseImage> builder)
        {
            builder.HasOne(x => x.Case)
                .WithMany(x => x.ImageList)
                .HasForeignKey(x => x.CaseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
