namespace HW7.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Search
    {
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string SearchTerm { get; set; }

        public DateTime SearchDate { get; set; }

        public string IPAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string Browser { get; set; }
    }
}
