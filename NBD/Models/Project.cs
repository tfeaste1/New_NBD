using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace NBD.Models
{
    public class Project : Auditable
    {
        public Project()
        {
            ProjectInventories = new HashSet<ProjectInventory>();
        }

        public int ID { get; set; }
        
       [Required(ErrorMessage ="Project Name is required.")]
       public string Name { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Estimated Start Date")]
        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EstStartDate { get; set; }

        [Display(Name = "Estimated End Date")]
        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EstEndDate { get; set; }

        [Display(Name = "Project Cost")]
        [Required(ErrorMessage = "Project Cost is required.")]
        [DataType(DataType.Currency)]
        public float? Amount { get; set; }

        [Display(Name = "Bid Amount")]
        [Required(ErrorMessage = "Bid Amount is required.")]
        [DataType(DataType.Currency)]
        public float? BidAmount { get; set; }

        [Display(Name = "Client-Approved")]
        [Required(ErrorMessage = "Please verify if client approved bid.")]
        public bool ClientApproval { get; set; }

        [Display(Name = "Administration-Approved")]
        [Required(ErrorMessage = "Please verify if administration approved bid.")]
        public bool AdminApproval { get; set; }

        [Display(Name = "Project Site")]
        public string ProdBidSite { get; set; }

        [Required(ErrorMessage = "Please choose a client.")]
        public int? ClientID { get; set; }

        [Display(Name = "Inventory List")]
        public ICollection<ProjectInventory> ProjectInventories { get; set; }


        public virtual Client Client { get; set; }


        public ICollection<Team> Teams { get; set; }
  



    }
}
