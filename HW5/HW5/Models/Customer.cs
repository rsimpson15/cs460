using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW5.Models
{
    public class Customer
    {

        [Range(0, 99999), Required]
        public int Id { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        [StringLength(100), Required]
        public string Street { get; set; }

        [StringLength(20), Required]
        public string City { get; set; }

        [StringLength(2), Required]
        public string StateCode { get; set; }

        [Range(0, 99999), Required]
        public int ZipCode { get; set; }

        [StringLength(20), Required]
        public string County { get; set; }

    } 
}
