using System;
using System.Collections.Generic;

namespace Restaurantmanagementlibrary.Models
{
    public partial class Category
    {
        public Category()
        {
            MenuLists = new HashSet<MenuList>();
        }

        public int Catid { get; set; }
        public string? Catname { get; set; }

        public virtual ICollection<MenuList> MenuLists { get; set; }
    }
}
