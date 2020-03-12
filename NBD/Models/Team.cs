using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Phase { get; set; }
        public string TeamName { get; set; }
       
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set;}
        public ICollection<LabourRequirement> LabourRequirements { get; set; }
}
}
