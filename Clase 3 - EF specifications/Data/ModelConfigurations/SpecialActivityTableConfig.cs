using Entities.Items;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ModelConfigurations
{
    public class SpecialActivityTableConfig : IEntityTypeConfiguration<SpecialActivityItem>
    {
        public void Configure(EntityTypeBuilder<SpecialActivityItem> e)
        {
            e.ToTable("t_special_activities");
        }
    }
}
