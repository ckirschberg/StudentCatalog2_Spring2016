using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCatalog2.Models
{
    public class Student
    {
        //C#
        public int StudentId { get; set; }
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Display(Name ="E-mail")]
        [Required(ErrorMessage = "Stupid user. Must fill out this")]
        [EmailAddress]
        public string Email { get; set; }
        public string MobilePhone { get; set; }


        //java
        //private string firstname;
        //public string getFirstname()
        //{
        //    return firstname;
        //}
        //public void setFirstname(string firstname)
        //{
        //    this.firstname = firstname;
        //}
    }
}