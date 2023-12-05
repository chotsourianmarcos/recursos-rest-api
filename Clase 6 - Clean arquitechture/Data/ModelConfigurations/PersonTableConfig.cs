using Entities.Items;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.ModelConfigurations
{
    public class PersonTableConfig : IEntityTypeConfiguration<PersonItem>
    {
        public void Configure(EntityTypeBuilder<PersonItem> e)
        {
            e.ToTable("t_persons");
        }
    }
}