using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.Api.Data;
using Sample.Api.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        readonly StoreDbContext _dbContext;
        public OrdersController(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _dbContext.Orders
                .Include(o => o.OrderItems).ThenInclude(oi => oi.Item)
                .ToArrayAsync();
        }
    }
}
