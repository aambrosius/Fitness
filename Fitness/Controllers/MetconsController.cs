using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Fitness.Models;

namespace Fitness.Controllers
{
    public class MetconsController : Controller
    {
        private FitnessContext db = new FitnessContext();

        // GET: Metcons
        public ActionResult Index() {
            @ViewBag.Type = new[] {"AMRAP", "For Time"};
            return View(db.Metcons.ToList());
        }

        // GET: Metcons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metcon metcon = db.Metcons.Find(id);
            if (metcon == null)
            {
                return HttpNotFound();
            }
            return View(metcon);
        }

        // GET: Metcons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metcons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MetconId,Name,Type,Description")] Metcon metcon)
        {
            if (ModelState.IsValid)
            {
                db.Metcons.Add(metcon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metcon);
        }

        // GET: Metcons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metcon metcon = db.Metcons.Find(id);
            if (metcon == null)
            {
                return HttpNotFound();
            }
            return View(metcon);
        }

        // POST: Metcons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MetconId,Name,Type,Description")] Metcon metcon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metcon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metcon);
        }

        // GET: Metcons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metcon metcon = db.Metcons.Find(id);
            if (metcon == null)
            {
                return HttpNotFound();
            }
            return View(metcon);
        }

        // POST: Metcons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Metcon metcon = db.Metcons.Find(id);
            db.Metcons.Remove(metcon);
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
