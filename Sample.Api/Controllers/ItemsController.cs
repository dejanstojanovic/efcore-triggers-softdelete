using Microsoft.AspNetCore.Mvc;
using Sample.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Item>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task Delete()
        {
            throw new NotImplementedException();
        }
    }
}
