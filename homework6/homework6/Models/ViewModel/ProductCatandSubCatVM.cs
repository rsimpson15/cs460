using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using homework6.Models;

namespace homework6.Models.ViewModel
{
    public class ProductCatandSubCatVM
    {

        public IEnumerable<ProductCategory> ProductCategoriesName { get; set; }
        public IEnumerable<ProductSubcategory> ProductSubcategoriesName { get; set; }
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Product> Product2 { get; set; }
        public IEnumerable<ProductModel> PModel { get; set; }
        public IEnumerable<ProductListPriceHistory> Price { get; set; }
        public IEnumerable<ProductReview> PReveiw { get; set; }
    }
}