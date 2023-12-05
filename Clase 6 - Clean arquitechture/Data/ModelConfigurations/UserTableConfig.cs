using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Items;

namespace Data.ModelConfigurations
{
    public class UserTableConfig : IEntityTypeConfiguration<UserItem>
    {
        public void Configure(EntityTypeBuilder<UserItem> e)
        {
            e.ToTable("t_users");
        }
    }
}