using Entities.Items;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelConfigurations
{
    public class QuotaTableConfig : IEntityTypeConfiguration<QuotaItem>
    {
        public void Configure(EntityTypeBuilder<QuotaItem> e)
        {
            e.ToTable("t_quotas");
        }
    }
}