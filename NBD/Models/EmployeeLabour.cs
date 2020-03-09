using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class EmployeeLabour
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "A Employee report name is required.")]
        [Display(Name = "Employee report Name")]
        public string EmployeeReport { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public int EmployeeID {get; set;}
        public Employee Employee { get; set; }

         public int Hour { get; set; }
        public int Cost { get; set; }

    }
}
