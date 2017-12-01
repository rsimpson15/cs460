using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.Models;

namespace HW8.Controllers
{
    public class ArtistsController : Controller
    {
        private ArtGallery db = new ArtGallery();

        // GET: Artists
        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        //https://stackoverflow.com/questions/25304610/how-to-get-a-list-from-mvc-controller-to-view-using-jquery-ajax
        // POST: Artists/Genre
        [HttpPost]
        public JsonResult GetGenre(string genre)
        {
            var artwork = db.Genres.FirstOrDefault(n => n.Name == genre).Classifications.ToList().OrderBy(t => t.Artwork.Title).Select(a => new { aw = a.ArtworkID, awa = a.Artwork.ArtworkID }).ToList();
            string[] artworkArtist = new string[artwork.Count()];
            for (int i = 0; i < artworkArtist.Length; ++i)
            {
                artworkArtist[i] = $"<td>{db.Artworks.Find(artwork[i].aw).Title}</td><td>{db.Artists.Find(artwork[i].awa).Name}</td>";
            }
            var data = new
            {
                arr = artworkArtist
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // GET: Artists
        public ActionResult Artists()
        {
            return View(db.Artists.ToList());
        }

        // GET: Artworks
        public ActionResult Artworks()
        {
            return View(db.Artworks.ToList());
        }

        // GET: Classifications
        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }


        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtistID,Name,Birthdate,BirthCountry,BirthCity")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artist);
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtistID,Name,Birthdate,BirthCountry,BirthCity")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        // GET: Artists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return RedirectToAction("Index");
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
