using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homework6.Models;

namespace homework6.Controllers
{
    public class PartialController : Controller
    {
        private AdventureWorksDbContext db = new AdventureWorksDbContext();

        [ChildActionOnly]
        public ActionResult SetNavBar()
        {
            var categories = db.ProductCategories.ToList();
            return View(categories);
        }
    }
}