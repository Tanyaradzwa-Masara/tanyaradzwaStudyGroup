using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tanyaradzwaStudyGroup.Models
{
    public class StudentList
    {
        [Display(Name = "Student Number")]
        [Required(ErrorMessage = "Student Number is mandatory & must start with a U")]
      
        public string StudentNumber { get; set; }
       
        [Display(Name = "Name")]
        
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Name is mandatory")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email_Address { get; set; }

        [Display(Name="Link to Personal Page")]
        public string myLink { get;set; }   
        
    }
}