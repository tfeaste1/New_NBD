using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace NBD.Models
{
    public class Client 
    {
        [Display(Name = "Client")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;             
                  
            }
        }
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage ="First Name can be no longer than 50 characters.")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required(ErrorMessage ="Last Name is required.")]
        [StringLength(50, ErrorMessage ="Last Name can be no longer than 50 characters.")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name can be no longer than 50 characters.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number (no spaces).")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}", ApplyFormatInEditMode = false)]
        public Int64 PhoneNumber { get; set; } 

       


        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(6, ErrorMessage = "Please enter a valid postal code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        


    }
}
