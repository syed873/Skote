using Skote.edmx;
using Skote.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skote.Services.Master.Dtos
{
    public class MasterListDto : BaseDto
    {
        public System.Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public System.Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        

        public virtual Customer Customer { get; set; }
        public virtual Order Orders1 { get; set; }
        public virtual Order Order1 { get; set; }
    }

    public class MasterChilEditDto
    {

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }

}