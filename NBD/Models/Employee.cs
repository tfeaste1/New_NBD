﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace NBD.Models
{
    public class Employee
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
        [StringLength(50, ErrorMessage="First Name can be no longer than 50 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage ="Last Name can be no longer than 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number (no spaces).")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:(###) ###-####}", ApplyFormatInEditMode = false)]
        public Int64 PhoneNumber { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department is required.")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<EmployeeLabour> EmployeeLabour { get; set; }
        
    }
}
