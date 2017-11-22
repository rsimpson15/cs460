namespace homework6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production.Product_2")]
    public partial class Product_2
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "money")]
        public decimal ListPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjPrice { get; set; }
    }
}
