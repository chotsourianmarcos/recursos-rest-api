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
    public class ActivityTableConfig : IEntityTypeConfiguration<ActivityItem>
    {
        public void Configure(EntityTypeBuilder<ActivityItem> e)
        {
            e.ToTable("t_activities");
        }
    }
}
