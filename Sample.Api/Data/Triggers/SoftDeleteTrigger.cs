using EntityFrameworkCore.Triggered;
using Microsoft.EntityFrameworkCore;
using Sample.Api.Data.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Api.Data.Triggers
{
    public class SoftDeleteTrigger : IBeforeSaveTrigger<ISoftDelete>
    {
        readonly StoreDbContext _dbContext;
        public SoftDeleteTrigger(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task BeforeSave(ITriggerContext<ISoftDelete> context, CancellationToken cancellationToken)
        {
            if (context.ChangeType == ChangeType.Deleted)
            {
                var entry =_dbContext.Entry(context.Entity);
                context.Entity.DeletedOn = DateTime.UtcNow;
                entry.State = EntityState.Modified;
            }

            await Task.CompletedTask;
        }
    }
}
