using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataCollection.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage ="Enter First Name")]
        [Display(Name ="First Name")]
        public string FName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Enter Registration Number (complete)")]
        [Display(Name = "Registration Number")]
        public string RegistrationNo { get; set; }

        [Required(ErrorMessage ="Enter Batch Number")]
        public int Batch { get; set; }
    }
}