using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace NBD.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Category Name is required.")]
        public string Name { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
