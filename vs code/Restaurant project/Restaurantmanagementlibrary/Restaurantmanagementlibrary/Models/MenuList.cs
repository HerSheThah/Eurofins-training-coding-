using System;
using System.Collections.Generic;

namespace Restaurantmanagementlibrary.Models
{
    public partial class MenuList
    {
        public MenuList()
        {
            Orders = new HashSet<Order>();
        }

        public int Menuid { get; set; }
        public string? Menuname { get; set; }
        public int? Catid { get; set; }
        public double? Price { get; set; }

        public virtual Category? Cat { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
