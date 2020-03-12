using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class ProductionPlan
    {
       
        public int ID { get; set; }

       
        [Display(Name = "Project")]
        public int ProjectID { get; set; }
        
        
        [Display(Name = "Staff")]
        public int TeamID { get; set; }
        
        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }

        [Display(Name ="Material Requirements")]
        public virtual ICollection<ProdPlanMaterial> ProdPlanMaterials { get; set; }

        [Display(Name ="Labour Requirements")]
        public virtual ICollection<ProdPlanLabour> ProdPlanLabours { get; set; }


    }
}
