//using Homework7.Models; //required to add the dbcontext class
using HW7.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;


namespace Homework7.Controllers
{
    public class SearchController : Controller
    {

        private Searches db = new Searches();

        public ActionResult Index(string termString, string rating)
        {
            // get the api key from a file outside the repo
            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["AppSecrets"];
            var ratingString = "&rating=" + rating;
            var topResult = "&limit=20";

            // build the requestURL
            var requestURL = "http://api.giphy.com/v1/gifs/search?q=" + termString + topResult + ratingString + "&api_key=" + apiKey;

            // build a WebRequest
            WebRequest request = WebRequest.Create(requestURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            // Read the content.  
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams and the response.  
            reader.Close();
            response.Close();

            // Create a JObject, using Newtonsoft NuGet package
            JObject json = JObject.Parse(responseFromServer);

            // Create a serializer to deserialize the string response (string in JSON format)
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // Store JSON results in results to be passed back to client (javascript)
            var results = serializer.DeserializeObject(responseFromServer);

            // Get Feilds for Database
            string IPAddress = Request.UserHostAddress;
            string Browser = Request.UserAgent;

            //Save data in DB
            if (ModelState.IsValid)
            {
                Search record = new Search();
                record.SearchTerm = termString;
                record.SearchDate = DateTime.Now;
                record.IPAddress = IPAddress;
                record.Browser = Browser;
                db.SaveChanges();
            }

            // return the Json object
            return Json(results, JsonRequestBehavior.AllowGet);
        }
    }
}