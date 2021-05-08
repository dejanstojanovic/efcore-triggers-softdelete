using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Data.Interfaces
{
    public interface ISoftDelete
    {
        public DateTime DeletedOn { get; set; }
    }
}
