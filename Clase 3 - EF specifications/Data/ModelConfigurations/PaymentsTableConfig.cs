using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.CustomRelations;

namespace Data.ModelConfigurations
{
    public class PaymentsTableConfig : IEntityTypeConfiguration<Payments>
    {
        public void Configure(EntityTypeBuilder<Payments> e)
        {
            e.ToTable("t_payments");
        }
    }
}