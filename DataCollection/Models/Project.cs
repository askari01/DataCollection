using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataCollection.Models
{
    public class Project
    {
        public int ID { get; set; }

        [Display(Name ="Student Name")]
        public int StudentID { get; set; }

        [Display(Name ="Teacher Name")]
        public int TeachersID { get; set; }

        [Display(Name ="Project Title")]
        public string ProjectName { get; set; }
        public virtual Teachers Teachers { get; set; }
        public virtual Student Student { get; set; }
        [DataType(DataType.MultilineText)]
        public string Discription { get; set; }
        
    }
}