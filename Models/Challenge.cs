using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Challenge
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = " Name :")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter Fundraising Program Name")]
        [Display(Name = " Program :")]
        public string Program { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = " Email:")]
        public string email { get; set; }


        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = " Address :")]
        public string address { get; set; }


        [Required(ErrorMessage = "Enter Zip")]
        [Display(Name = " Zip :")]
        public string zip { get; set; }

        [Required(ErrorMessage = "Enter City")]
        [Display(Name = " City :")]
        public string city { get; set; }

        [Required(ErrorMessage = "Enter Country")]
        [Display(Name = " Country :")]
        public string country { get; set; }
    }
}
