using Entities.Items;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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