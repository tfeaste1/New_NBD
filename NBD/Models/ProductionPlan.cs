using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class ProductionPlan
    {
        [Display(Name="Staff")]
        public int ID { get; set; }
       
        [Display(Name = "Project")]
        public int ProjectID { get; set; }
        
        [Display(Name = "Staff")]
        public int TeamID { get; set; }
        
        [Display(Name = "Labour Requirements")]
        public int LabourReq { get; set; }
        
        [Display(Name = "Material Requirements")]
        public int MaterialReq { get; set; }

        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }
        public virtual LabourRequirement LabourRequirement { get; set; }
        public virtual MaterialRequirement MaterialRequirement { get; set; }
    }
}
