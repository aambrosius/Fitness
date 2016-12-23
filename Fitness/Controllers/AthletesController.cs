using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Fitness.Models;

namespace Fitness.Controllers
{
    public class AthletesController : Controller
    {
        private FitnessContext db = new FitnessContext();

        // GET: People  
        [HttpGet]
        public ActionResult Index() {
            //var athletes = Utilities.Utility.LoadAthleteJson();
            return View(db.Athletes.ToList());
        }
        // Create Json file  
        //here i am not passing anything from view to controller  
        //[HttpPost]
        //public ActionResult Index(Athlete obj)
        //{
        //    // retrive the data from table  
        //    var athletelist = db.Athletes.ToList();
        //    // Pass the "personlist" object for conversion object to JSON string  
        //    string jsondata = new JavaScriptSerializer().Serialize(athletelist);
        //    string path = Server.MapPath("~/App_Data/");
        //    // Write that JSON to txt file,  
        //    System.IO.File.WriteAllText(path + "output.json", jsondata);
        //    TempData["msg"] = "Json file Generated! check this in your App_Data folder";
        //    return RedirectToAction("Index"); ;
        //}

        // GET: Athletes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // GET: Athletes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Athletes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,NickName")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                db.Athletes.Add(athlete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(athlete);
        }

        // GET: Athletes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // POST: Athletes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,NickName")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(athlete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(athlete);
        }

        // GET: Athletes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Athlete athlete = db.Athletes.Find(id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        // POST: Athletes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Athlete athlete = db.Athletes.Find(id);
            db.Athletes.Remove(athlete);
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
