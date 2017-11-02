using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
<<<<<<< HEAD
=======
using System.Net;
>>>>>>> feature_page3

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
<<<<<<< HEAD
            string word;
            string lang;

            if (!string.IsNullOrEmpty(Request.Form["feildOne"]) && !string.IsNullOrEmpty(Request.Form["feildTwo"]))
            {
                word = Request.Form["feildOne"];
                lang = Request.Form["feildTwo"];
                int size = word.Length - 2;

=======
            //Variables
            string word;
            string lang;

            //Test if our fields now hold values instead of nulls
            if (!string.IsNullOrEmpty(Request.Form["feildOne"]) && !string.IsNullOrEmpty(Request.Form["feildTwo"]))
            {
                //Input the field data to our vairables
                word = Request.Form["feildOne"];
                lang = Request.Form["feildTwo"];
                //Create a reusable size variable
                int size = word.Length - 2;

                //If the langauge is Piglatin
>>>>>>> feature_page3
                if (lang == "P" || lang == "p")
                {
                    string flavor = "ay";
                    if (word.Length == 1)
                    {
<<<<<<< HEAD
=======
                        //For one letter words just attach "ay" to it
>>>>>>> feature_page3
                        ViewBag.word = word + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 2)
                    {
<<<<<<< HEAD
=======
                        //For two letter words swap the letter positions and attach "ay"
>>>>>>> feature_page3
                        string first = word.Substring(0, 0);
                        string last = word.Substring(1, 1);
                        ViewBag.word = last + first + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 3)
                    {
<<<<<<< HEAD
=======
                        //For three letter words, take the first two, move them to the rear and attach "ay"
>>>>>>> feature_page3
                        string start = word.Substring(0, 1);
                        string end = word.Substring(2, 2);
                        ViewBag.word = end + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else
                    {
<<<<<<< HEAD
=======
                        //For all other cases,take the front two letter and move them to the rear, then attach "ay"
>>>>>>> feature_page3
                        string start = word.Substring(0, 1).ToLower();
                        string bulk = word.Substring(2, size);
                        ViewBag.word = bulk + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                }
<<<<<<< HEAD
                else if (lang == "E" || lang == "e")
                {
=======
                //If language is English
                else if (lang == "E" || lang == "e")
                {
                    //Take the rear two letters and move them to the front, remove "ay"
>>>>>>> feature_page3
                    string end = word.Substring(word.Length - 3, size - 2);
                    string bulk = word.Substring(0, size - 4);
                    ViewBag.word = end + bulk;
                    ViewData["word"] = ViewBag.word;
                    return View();
                }
                else
                {
<<<<<<< HEAD
=======
                    //If langauge is not English or Piglatin throw an error message
>>>>>>> feature_page3
                    ViewBag.ErrorMessage = "Please enter E for English or P for Piglatin.";
                    return View();
                }
            }
            else
            {
<<<<<<< HEAD
=======
                //If one of the feilds is null, throw an error message
>>>>>>> feature_page3
                ViewBag.ErrorMessage = "Please enter a value for both feilds.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Page2()
        {
            //Get Method
            ViewBag.RequestMethod = "GET";
            return View();
        }

        [HttpPost]
        public ActionResult Page2(string feildOne, string feildTwo)
        {
            //Post Method
            ViewBag.RequestMethod = "POST";

            //Variables
            string word;
            string lang;

            //Check if the fields are no longer null
            if (!string.IsNullOrEmpty(feildOne) && !string.IsNullOrEmpty(feildTwo))
            {
                //If so, put the field data into variables
                word = feildOne;
                lang = feildTwo;
                //Create a size variable
                int size = word.Length - 2;

                //If the langauge is Piglatin
                if (lang == "P" || lang == "p")
                {
                    string flavor = "ay";
                    if (word.Length == 1)
                    {
                        //For one letter words just attach "ay" to it
                        ViewBag.word = word + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 2)
                    {
                        //For two letter words swap the letter positions and attach "ay"
                        string first = word.Substring(0, 0);
                        string last = word.Substring(1, 1);
                        ViewBag.word = last + first + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else if (word.Length == 3)
                    {
                        //For three letter words, take the first two, move them to the rear and attach "ay"
                        string start = word.Substring(0, 1);
                        string end = word.Substring(2, 2);
                        ViewBag.word = end + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                    else
                    {
                        //For all other cases,take the front two letter and move them to the rear, then attach "ay"
                        string start = word.Substring(0, 1).ToLower();
                        string bulk = word.Substring(2, size);
                        ViewBag.word = bulk + start + flavor;
                        ViewData["word"] = ViewBag.word;
                        return View();
                    }
                }
                //If language is English
                else if (lang == "E" || lang == "e")
                {
                    //Take the rear two letters and move them to the front, remove "ay"
                    string end = word.Substring(word.Length - 3, size - 2);
                    string bulk = word.Substring(0, size - 4);
                    ViewBag.word = end + bulk;
                    ViewData["word"] = ViewBag.word;
                    return View();
                }
                else
                {
                    //If langauge is not English or Piglatin throw an error message
                    ViewBag.ErrorMessage = "Please enter E for English or P for Piglatin.";
                    return View();
                }
            }
            else
            {
                //If one of the feilds is null, throw an error message
                ViewBag.ErrorMessage = "Please enter a value for both feilds.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Page3()
        {
            //Get Method
            ViewBag.RequestMethod = "GET";
            return View();
        }

        [HttpPost]
        public ActionResult Page3(decimal? amount, decimal? interest, decimal? term)
        {
            //Post Method
            ViewBag.RequestMethod = "POST";

            //Variables
            decimal principle, rate, time, total;

            //Test if our fields are null
            if (amount != null && interest != null && term != null)
            {
                //Double check the format by converting
                principle = Convert.ToDecimal(amount);
                rate = Convert.ToDecimal(interest);
                time = Convert.ToDecimal(term);

                //Perform math calculation
                total = (principle * time * rate) / 100;

                ViewBag.total = total;
                return View();
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
    }
}