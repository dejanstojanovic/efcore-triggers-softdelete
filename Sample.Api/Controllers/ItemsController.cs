using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.Api.Data;
using Sample.Api.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        readonly StoreDbContext _dbContext;
        public ItemsController(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
          return  await _dbContext.Items.ToArrayAsync();
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            var item = await _dbContext.Items.FindAsync(id);
            if (item != null)
                _dbContext.Items.Remove(item);

            await _dbContext.SaveChangesAsync();
        }
    }
}
