using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public double AvgNet { get; set; }
        public double List { get; set; }
        public int SizeAmount { get; set; }
        public string SizeUnit { get; set; }
        public int Quantity { get; set; }
        public int MaterialID { get; set; }
        public virtual Material Material { get; set; }

        public virtual ICollection<MaterialRequirement> MaterialRequirements { get; set; }
    }
}
