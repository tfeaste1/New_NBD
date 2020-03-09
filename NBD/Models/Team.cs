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
        [Required(ErrorMessage = "A team name is required.")]
        [Display (Name = "Team Name")]
        public string TeamName { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set;}
}
}
