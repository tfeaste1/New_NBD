using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class ProjectInventory
    {
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public int InventoryID { get; set; }
        public Inventory Inventory { get; set; }
    }
}
