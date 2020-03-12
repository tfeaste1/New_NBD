using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class MR
    {
        public int ID { get; set; }

        public DateTime? date { get; set; }
        public int Qnty { get; set; }

        public int Cost { get; set; }

        public int ExtCost
        {
            get
            {
                return Qnty * Cost;
            }
        }

        public int MaterialID { get; set; }
        public Material Material { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }
}
