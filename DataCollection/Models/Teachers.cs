﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataCollection.Models
{
    public class Teachers
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Enter First Name")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        //[Display(Name = "First Name")]
        [Required]
        [StringLength(100, ErrorMessage = "Enter Designation")]
        public string Designation { get; set; }

        [Display(Name = "Project Evulation Committee")]
        public Boolean PREC { get; set; }

        [Display(Name = "Evaluation Committee")]
        public Boolean EC { get; set; }

        [Display(Name = "Project Coordinator")]
        public Boolean ProjCoordinator { get; set; }
    }
}