using Sample.Api.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace Sample.Api.Domain
{
    public class Item : ISoftDelete
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
