using Microsoft.EntityFrameworkCore;
using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Parnas.Infrastructure.Config
{
    public class BaseEntityConfig : IEntityTypeConfiguration<BaseEntity<string>>
    {
        public void Configure(EntityTypeBuilder<Base.BaseEntity<string>> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
