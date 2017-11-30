//using Homework7.Models; //required to add the dbcontext class
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

        public ActionResult Index(string termString, string rating)
        {
            // get the api key from a file outside the repo
            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["AppSecrets"];

            var ratingString = "&rating=" + rating;

            // build the requestURL
            var requestURL = "http://api.giphy.com/v1/gifs/search?q=" + termString + ratingString + "&api_key=" + apiKey;

            // build a WebRequest
            WebRequest request = WebRequest.Create(requestURL);

            // get the response from the WebRequest via the passed URL
            WebResponse response = request.GetResponse();

            // build a Stream AND get the Stream Response
            Stream dataStream = response.GetResponseStream();

            //StreamReader reader = new StreamReader(dataStream);
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

            // get userIP and userAgent for tracking purposes
            string userIP = Request.UserHostAddress;
            string userAgent = Request.UserAgent;

            // return the Json object
            return Json(results, JsonRequestBehavior.AllowGet);
        }
    }
}