using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryController.Data.Entities
{
    public class DbItems 
    {
        public int ItemId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }
}
