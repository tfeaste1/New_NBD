using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.ViewModels
{
    public class MaterialReqVM
    {
        public int ID { get; set; }
        public string MaterialName { get; set; }
        public string Size { get; set; }
        public float? NetUnit { get; set; }
        public float? Cost { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public DateTime? InstallDateTime { get; set; }
        
    }
}
