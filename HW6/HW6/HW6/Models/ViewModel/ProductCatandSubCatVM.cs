using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW6.Models;

namespace HW6.Models.ViewModel
{
    public class ProductCatandSubCatVM
    {

        public IEnumerable<ProductCategory> CatList { get; set; }
        public IEnumerable<ProductSubcategory> SubCatList { get; set; }

    }
}