using Microsoft.AspNetCore.Mvc;
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
        public OrdersController()
        {

        }

        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
