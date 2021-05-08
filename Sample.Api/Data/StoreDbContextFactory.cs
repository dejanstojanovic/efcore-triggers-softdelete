using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Sample.Api.Data
{
    public class StoreDbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var dbContext = StoreDbContext.CreateContext();
            dbContext.Database.Migrate();
            return dbContext;
        }

    }
}
