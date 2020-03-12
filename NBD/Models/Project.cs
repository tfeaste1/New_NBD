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
       

        public int ID { get; set; }
        
        [Required(ErrorMessage ="Project Name is required.")]
         public string Name { get; set; }

        [Display(Name = "Project Site")]
        public string ProjSite { get; set; }

        public DateTime? ProjBidDate { get; set; }

        [Display(Name = "Estimated Start Date")]
        [Required(ErrorMessage = "Estimated Start Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EstStartDate { get; set; }

        [Display(Name = "Estimated End Date")]
        [Required(ErrorMessage = "Estimated End Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EstEndDate { get; set; }
       
        [Display(Name = " Actual Start Date")]
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Actual End Date")]
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Actual Project Cost")]
        
        [DataType(DataType.Currency)]
        public float? ActAmount { get; set; }

        [Display(Name = "Estimated Project Cost")]
        [Required(ErrorMessage = "Bid Amount is required.")]
        [DataType(DataType.Currency)]
        public float? EstAmount { get; set; }

        [Display(Name = "Client-Approved")]
        [Required(ErrorMessage = "Please verify if client approved bid.")]
        public bool ClientApproval { get; set; }

        [Display(Name = "Administration-Approved")]
        [Required(ErrorMessage = "Please verify if administration approved bid.")]
        public bool AdminApproval { get; set; }

        

        [Display(Name="Project Phase")]
        public string ProjCurrentPhase { get; set; }

        [Required(ErrorMessage = "Please choose a client.")]
        public int? ClientID { get; set; }

        public bool ProjIsFlagged { get; set; }

        [Display(Name = "Inventory List")]
        
        public ICollection<LabourSummary> LabourSummaries { get; set; }
        //public ICollection<MaterialRequirement> MaterialRequirements { get; set; }
        public ICollection<ProductionTool> ProductionTools { get; set; }


        public virtual Client Client { get; set; }


        public ICollection<Team> Teams { get; set; }

        public ICollection<WReport> WReports { get; set; }

        public ICollection<MR> MRs{ get; set; }



    }
}
