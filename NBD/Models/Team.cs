﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class Team
    {
        public Team()
        {
            this.LabourRequirements = new HashSet<LabourRequirement>();
            ProductionPlans = new HashSet<ProductionPlan>();
            this.Projects = new HashSet<Project>();
            this.TeamEmployees = new HashSet<TeamEmployee>();
        }
        public int ID { get; set; }
        public string Phase { get; set; }

        [Required(ErrorMessage = "Team Name is required.")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

     

        public ICollection<LabourRequirement> LabourRequirements { get; set; }
       
        public ICollection<ProductionPlan>ProductionPlans { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<TeamEmployee> TeamEmployees { get; set; }
    }
}
