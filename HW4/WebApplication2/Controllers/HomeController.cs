using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Page1()
        {
            string word;
            string lang;

            if (!string.IsNullOrEmpty(Request.Form["feildOne"]) && !string.IsNullOrEmpty(Request.Form["feildTwo"]))
            {
                word = Request.Form["feildOne"];
                lang = Request.Form["feildTwo"];
                int size = word.Length - 2;

                if (lang == "P" || lang == "p")
                {
                    string flavor = "ay";
                    if (word.Length == 1)
                    {
                        ViewBag.word = word + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 2)
                    {
                        string first = word.Substring(0, 0);
                        string last = word.Substring(1, 1);
                        ViewBag.word = last + first + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 3)
                    {
                        string start = word.Substring(0, 1);
                        string end = word.Substring(2, 2);
                        ViewBag.word = end + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else
                    {
                        string start = word.Substring(0, 1).ToLower();
                        string bulk = word.Substring(2, size);
                        ViewBag.word = bulk + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                }
                else if (lang == "E" || lang == "e")
                {
                    string end = word.Substring(word.Length - 3, size - 2);
                    string bulk = word.Substring(0, size - 4);
                    ViewBag.word = end + bulk;
                    ViewData["word"] = ViewBag.word;
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Please enter E for English or P for Piglatin.";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Please enter a value for both feilds.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Page2()
        {
            ViewBag.RequestMethod = "GET";
            return View();
        }

        [HttpPost]
        public ActionResult Page2(string feildOne, string feildTwo)
        {
            ViewBag.RequestMethod = "POST";

            string word;
            string lang;

            if (!string.IsNullOrEmpty(feildOne) && !string.IsNullOrEmpty(feildTwo))
            {
                word = feildOne;
                lang = feildTwo;
                int size = word.Length - 2;

                if (lang == "P" || lang == "p")
                {
                    string flavor = "ay";
                    if (word.Length == 1)
                    {
                        ViewBag.word = word + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 2)
                    {
                        string first = word.Substring(0, 0);
                        string last = word.Substring(1, 1);
                        ViewBag.word = last + first + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 3)
                    {
                        string start = word.Substring(0, 1);
                        string end = word.Substring(2, 2);
                        ViewBag.word = end + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else
                    {
                        string start = word.Substring(0, 1).ToLower();
                        string bulk = word.Substring(2, size);
                        ViewBag.word = bulk + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                }
                else if (lang == "E" || lang == "e")
                {
                    string end = word.Substring(word.Length - 3, size - 2);
                    string bulk = word.Substring(0, size - 4);
                    ViewBag.word = end + bulk;
                    ViewData["word"] = ViewBag.word;
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Please enter E for English or P for Piglatin.";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Please enter a value for both feilds.";
                return View();
            }
        }

        public ActionResult Page3()
        {
            return View();
        }
    }
}