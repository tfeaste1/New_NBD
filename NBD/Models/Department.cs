using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace NBD.Models
{
    public class Department
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter a department name.")]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        

    }
}
