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
        public string PName { get; set; }


        [Required(ErrorMessage = "Enter Amount")]
        [Display(Name = " Amount :")]
        public string PAmount { get; set; }

        [Required(ErrorMessage = "Enter Card Number")]
        [Display(Name = " CardNumber :")]
        public string PCardNumber { get; set; }

        [Required(ErrorMessage = "Enter CVV")]
        [Display(Name = " CVV :")]
        public string PCVV { get; set; }

        [Required(ErrorMessage = "Enter Expiration Date")]
        [Display(Name = " ExpirationDate :")]
        public string PExpirationDate { get; set; }
        
    }
}
