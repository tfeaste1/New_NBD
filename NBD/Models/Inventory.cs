using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace NBD.Models
{
    public class Inventory

    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
         
        public string Name { get; set; }

        [Required(ErrorMessage = "Product Code is required.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Unit Cost is required.")]
        [DataType(DataType.Currency)]

        public float? UnitCost { get; set; }
        
        [Required(ErrorMessage = "Please Choose a Category.")]
        public int CategoryID { get; set; }
 
        public virtual Category Category { get; set; }
        public ICollection<ProjectInventory> ProjectInventories { get; set; }
    }
}
