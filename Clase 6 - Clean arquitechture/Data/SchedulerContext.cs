using Data;
using Entities.CustomRelations;
using Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Data
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext(DbContextOptions<SchedulerContext> options) : base(options) { }
        public DbSet<PersonItem> Persons { get; set; }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<ActivityItem> Activities { get; set; }
        public DbSet<QuotaItem> Quotas { get; set; }
        public DbSet<Payments> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }

            foreach (var property in builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,2)");
            }

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
public class ServiceContextFactory : IDesignTimeDbContextFactory<SchedulerContext>
{
    public SchedulerContext CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", false, true);
        var config = builder.Build();
        var connectionString = config.GetConnectionString("ServiceContext");
        var optionsBuilder = new DbContextOptionsBuilder<SchedulerContext>();
        optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

        return new SchedulerContext(optionsBuilder.Options);
    }
}