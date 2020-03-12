﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class MaterialRequirement
    {
        public int ID { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public DateTime? InstallDate { get; set; }
        public DateTime? InstallTime { get; set; }
        public int EstQuantity { get; set; }
        public int Quantity { get; set; }
        public int InventoryID { get; set; }
        public virtual Inventory Inventory { get; set; }

        public virtual ICollection<ProjectMaterial> ProjectMaterials { get; set; }
        public virtual ICollection<ProdPlanMaterial> ProdPlanMaterials { get; set; }

    }
}
