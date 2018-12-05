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
    public class PaymentInformationsController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: PaymentInformations
        public ActionResult Index()
        {
            var paymentInformations = db.PaymentInformations.Include(p => p.Client);
            return View(paymentInformations.ToList());
        }

        // GET: PaymentInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentInformation paymentInformation = db.PaymentInformations.Find(id);
            if (paymentInformation == null)
            {
                return HttpNotFound();
            }
            return View(paymentInformation);
        }

        // GET: PaymentInformations/Create
        public ActionResult Create()
        {
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName");
            return View();
        }

        // POST: PaymentInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaymentID,CardNumber,NameOnCard,CVC,ClientID")] PaymentInformation paymentInformation)
        {
            if (ModelState.IsValid)
            {
                db.PaymentInformations.Add(paymentInformation);
                db.SaveChanges();
                return RedirectToAction("PaymentSubmissionConfirmation", "Client");
            }

            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", paymentInformation.ClientID);
            return View(paymentInformation);
        }

        // GET: PaymentInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentInformation paymentInformation = db.PaymentInformations.Find(id);
            if (paymentInformation == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", paymentInformation.ClientID);
            return View(paymentInformation);
        }

        // POST: PaymentInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaymentID,CardNumber,NameOnCard,CVC,ClientID")] PaymentInformation paymentInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientID = new SelectList(db.Clients, "ClientID", "ClientName", paymentInformation.ClientID);
            return View(paymentInformation);
        }

        // GET: PaymentInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentInformation paymentInformation = db.PaymentInformations.Find(id);
            if (paymentInformation == null)
            {
                return HttpNotFound();
            }
            return View(paymentInformation);
        }

        // POST: PaymentInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentInformation paymentInformation = db.PaymentInformations.Find(id);
            db.PaymentInformations.Remove(paymentInformation);
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
