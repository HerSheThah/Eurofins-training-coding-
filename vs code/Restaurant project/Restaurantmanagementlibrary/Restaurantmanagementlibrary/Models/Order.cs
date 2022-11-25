using System;
using System.Collections.Generic;

namespace Restaurantmanagementlibrary.Models
{
    public partial class Order
    {
        public int Orderid { get; set; }
        public int? Custid { get; set; }
        public int? Menuid { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Orderdate { get; set; }
        public double? Totalprice { get; set; }

        public virtual Customer? Cust { get; set; }
        public virtual MenuList? Menu { get; set; }
    }
}
