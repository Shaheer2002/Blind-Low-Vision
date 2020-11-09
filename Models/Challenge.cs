﻿using System;
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
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = " Address :")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Enter Zip")]
        [Display(Name = " Zip :")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Enter City")]
        [Display(Name = " City :")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter Country")]
        [Display(Name = " Country :")]
        public string Country { get; set; }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = " Name :")]
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
