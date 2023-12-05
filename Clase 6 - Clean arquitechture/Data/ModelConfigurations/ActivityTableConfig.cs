using Entities.Items;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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