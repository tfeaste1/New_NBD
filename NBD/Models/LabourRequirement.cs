using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class LabourRequirement
    {
        public int ID { get; set; }
        public DateTime? EstDate { get; set; }
        public int EstHours { get; set; }
        public DateTime? Date { get; set; }
        public int Hours { get; set; }
        public string Comments { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }

        public int LabourSummaryID { get; set; }
        public virtual LabourSummary LabourSummary { get; set; }

        public int TaskID { get; set; }
        public virtual Task Task { get; set; }

        public virtual ICollection<ProjectLabour> ProjectLabours { get; set; }
        public virtual ICollection<ProdPlanLabour> ProdPlanLabours { get; set; }
    }
}
