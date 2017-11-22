using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using homework6.Models;
using System.Globalization;
using homework6.Models.ViewModel;

namespace homework6.Controllers
{
    public class ProductController : Controller
    {
        private AdventureWorksDbContext db = new AdventureWorksDbContext();

        // GET: Product
        public ActionResult Index(int? id, int?subID)
        {
            ProductCatandSubCatVM vm = new ProductCatandSubCatVM() {
                ProductCategoriesName = db.ProductCategories,
                ProductSubcategoriesName = db.ProductSubcategories
            };

            if(id != null && db.ProductCategories.Find(id) != null)
            {
                ViewBag.ID = id;
            }

            return View(vm);
        }

        public ActionResult Browse(int? id){
            ViewBag.SubID = id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCatandSubCatVM vm = new ProductCatandSubCatVM()
            {
                ProductCategoriesName = db.ProductCategories,
                ProductSubcategoriesName = db.ProductSubcategories.Where(p => p.ProductCategory.ProductCategoryID == id),
                Product = db.ProductSubcategories.ToList()[id.Value - 1].Products.ToList()
            };
            ViewBag.Count = vm.Product.Count() / 10;

            return View(vm);
         }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProductCatandSubCatVM vm = new ProductCatandSubCatVM()
            {
                ProductCategoriesName = db.ProductCategories,
                ProductSubcategoriesName = db.ProductSubcategories,
                Product = db.Products.ToList(),
                PReveiw = db.ProductReviews.ToList()
            };

            ViewBag.pName = db.Products.Where(p => p.ProductID == id).Select(p => p.Name).FirstOrDefault().ToString();
            ViewBag.pWeight = db.Products.Where(p => p.ProductID == id).Select(p => p.Weight).FirstOrDefault().ToString();
            ViewBag.pSize = db.Products.Where(p => p.ProductID == id).Select(p => p.Size).FirstOrDefault().ToString();
            ViewBag.pCost = db.Products.Where(p => p.ProductID == id).Select(p => p.ListPrice).FirstOrDefault().ToString(); ;
            ViewBag.pColor = db.Products.Where(p => p.ProductID == id).Select(p => p.Color).FirstOrDefault().ToString();
            ViewBag.pPhoto = db.ProductProductPhotoes.Where(p => p.ProductID == id).Select(c => c.ProductPhoto.LargePhoto).FirstOrDefault();

            return View(vm);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
