using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Donation
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [Display (Name = " Name :")]
        public string Owner { get; set; }


        [Required(ErrorMessage = "Enter Amount")]
        [Display(Name = " Amount :")]
        public string Amount { get; set; }


        [Required(ErrorMessage = "Enter Card Number")]
        [Display(Name = " CardNumber :")]
        public string CardNumber { get; set; }


        [Required(ErrorMessage = "Enter CVV")]
        [Display(Name = " CVV :")]
        public string CVV { get; set; }


        [Required(ErrorMessage = "Enter Expiration Date")]
        [Display(Name = " ExpirationDate :")]
        public string ExpirationDate { get; set; }
        
    }
}
