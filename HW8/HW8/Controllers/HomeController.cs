using HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {

        private ArtGallery db = new ArtGallery();

        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        //https://stackoverflow.com/questions/25304610/how-to-get-a-list-from-mvc-controller-to-view-using-jquery-ajax
        // POST: Artists/Genre
        [HttpPost]
        public JsonResult GetGenre(int? genre)
        {
            var artwork = db.Genres.FirstOrDefault(n => n.GenreID == genre).Classifications.ToList().OrderBy(t => t.Artwork.Title).Select(a => new { aw = a.ArtworkID, awa = a.Artwork.ArtistID }).ToList();
            string[] artworkArtist = new string[artwork.Count()];
            for (int i = 0; i < artworkArtist.Length; ++i)
            {
                var artistName = db.Artists.Where(awa => awa.ArtistID == artwork[i].awa).Select(a => a.Name).ToList();
                var artworkName = db.Artworks.Where(aw => aw.ArtworkID == artwork[i].aw).Select(a => a.Title).ToList();
                artworkArtist[i] = $"<td>{artworkName}</td><td>{artistName}</td>";
            }
            var data = new
            {
                arr = artworkArtist
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}