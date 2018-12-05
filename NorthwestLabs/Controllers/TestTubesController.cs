using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using NorthwestLabs.Models;

namespace NorthwestLabs.Controllers
{
    public class TestTubesController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: TestTubes
        public ActionResult Index()
        {
            var testTubes = db.TestTubes.Include(t => t.Compound).Include(t => t.TestTubeStatus);
            return View(testTubes.ToList());
        }

        // GET: TestTubes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTube testTube = db.TestTubes.Find(id);
            if (testTube == null)
            {
                return HttpNotFound();
            }
            return View(testTube);
        }

        // GET: TestTubes/Create
        public ActionResult Create()
        {
            ViewBag.LTNumber = new SelectList(db.Compounds, "LTNumber", "CompoundDescription");
            ViewBag.TestTubeStatusID = new SelectList(db.TestTubeStatus, "TestTubeStatusID", "TestTubeStatusDescription");
            return View();
        }

        // POST: TestTubes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TestSerialNumber,TestTubeID,Concentration,TestTubeStatusID,LTNumber")] TestTube testTube)
        {
            if (ModelState.IsValid)
            {
                db.TestTubes.Add(testTube);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LTNumber = new SelectList(db.Compounds, "LTNumber", "CompoundDescription", testTube.LTNumber);
            ViewBag.TestTubeStatusID = new SelectList(db.TestTubeStatus, "TestTubeStatusID", "TestTubeStatusDescription", testTube.TestTubeStatusID);
            return View(testTube);
        }

        // GET: TestTubes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTube testTube = db.TestTubes.Find(id);
            if (testTube == null)
            {
                return HttpNotFound();
            }
            ViewBag.LTNumber = new SelectList(db.Compounds, "LTNumber", "CompoundDescription", testTube.LTNumber);
            ViewBag.TestTubeStatusID = new SelectList(db.TestTubeStatus, "TestTubeStatusID", "TestTubeStatusDescription", testTube.TestTubeStatusID);
            return View(testTube);
        }

        // POST: TestTubes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TestSerialNumber,TestTubeID,Concentration,TestTubeStatusID,LTNumber")] TestTube testTube)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testTube).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LTNumber = new SelectList(db.Compounds, "LTNumber", "CompoundDescription", testTube.LTNumber);
            ViewBag.TestTubeStatusID = new SelectList(db.TestTubeStatus, "TestTubeStatusID", "TestTubeStatusDescription", testTube.TestTubeStatusID);
            return View(testTube);
        }

        // GET: TestTubes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTube testTube = db.TestTubes.Find(id);
            if (testTube == null)
            {
                return HttpNotFound();
            }
            return View(testTube);
        }

        // POST: TestTubes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TestTube testTube = db.TestTubes.Find(id);
            db.TestTubes.Remove(testTube);
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

        public ActionResult Query()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Query(string TestSerialNumber)
        {
            return RedirectToAction("Edit", "TestTubes", new { id = TestSerialNumber });
        }
    }
}
