using System;
using System.Collections.Generic;

namespace Restaurantmanagementlibrary.Models
{
    public partial class Dinein
    {
        public int Bookingid { get; set; }
        public int? Custid { get; set; }
        public DateTime? Bookingdate { get; set; }
        public int? Tableno { get; set; }

        public virtual Customer? Cust { get; set; }
    }
}
