using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.ViewModels
{
    public class LabourReqVM
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }

        public float? CostPerHour { get; set; }
        public float? Cost { get; set; }
        
        public DateTime? Time {get;set;}
         public string Task { get; set; }
    }
}
