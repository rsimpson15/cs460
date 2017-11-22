using HW6.Models;
using HW6.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW6.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsContext data = new ProductsContext();

        //Major Catagory Return
        //id = catid
        public ActionResult Index(int? id)
        {
            ProductCatandSubCatVM vm = new ProductCatandSubCatVM();
            vm.CatList = vm.CatList;

            if (id != null && data.ProductCategories.Find(id) != null)
            {
                ViewBag.ID = id.Value;
                vm.SubCatList = vm.SubCatList.Where(p => p.ProductCategoryID == id.Value).ToList();
            }
            return View(vm);
        }

        //Gets the products 
        //id = subid
        public ActionResult Products(int? id)
        {
            if (id == null || data.ProductSubcategories.Find(id) == null)
            {
                return new HttpNotFoundResult();
            }
            // get all the products that match the product subcategory that was passed in
            var products = data.ProductSubcategories.Find(id).Products.ToList();

            return View(products);
        }

        // get individual products
        // param id = ProductID;
        public ActionResult Product(int? id)
        {
            if (id == null || data.Products.Find(id) == null)
            {
                return new HttpNotFoundResult();
            }

            var product = data.Products.Find(id);

            return View(product);
        }

    }
}