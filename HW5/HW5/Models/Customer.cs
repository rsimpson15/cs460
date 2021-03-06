﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HW5.DAL;
using HW5.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW5.Models
{
    public class Customer
    {

        [Range(0, 99999), Required, Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [Display(Name="Date of Birth")]
        public DateTime Dob { get; set; }

        [StringLength(50), Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [StringLength(100), Required]
        public string Street { get; set; }

        [StringLength(20), Required]
        public string City { get; set; }

        [StringLength(2), Required]
        [Display(Name = "State")]
        public string StateCode { get; set; }

        [Range(0, 99999), Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [StringLength(20), Required]
        public string County { get; set; }

    } 
}
