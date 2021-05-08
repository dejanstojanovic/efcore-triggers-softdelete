using System;
using System.Collections.Generic;

namespace Sample.Api.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
