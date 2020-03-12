using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBD.Models
{
    public class WReport
    {
        public int ID { get; set; }

        public DateTime? date { get; set; }
        public int Hour { get; set; }

        public int Cost { get; set; }

        public int ExtCost
        {
            get
            {
                return Hour * Cost;
            }
        }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int TaskID { get; set; }
        public Task Task { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }

    }
}
