using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sample.Api.Constants;
using Sample.Api.Domain;
using System.IO;

namespace Sample.Api.Data
{
    public class StoreDbContext:DbContext
    {
        internal static StoreDbContext CreateContext()
        {
            return new StoreDbContext(new DbContextOptionsBuilder<StoreDbContext>().UseSqlServer(
                 new ConfigurationBuilder()
                     .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), $"appsettings.json"))
                     .AddEnvironmentVariables()
                     .Build()
                     .GetConnectionString(DbContextConfigConstants.DB_CONNECTION_CONFIG_NAME)
                 ).Options);
        }

        public StoreDbContext() : base()
        {

        }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
