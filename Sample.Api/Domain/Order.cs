using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
