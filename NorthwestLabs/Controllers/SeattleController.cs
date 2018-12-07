using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class SeattleController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        // GET: Seattle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProcessApproval()
        {
            return View();
        }

        public ActionResult ClientWorkOrders()
        {
            return View();
        }

        public ActionResult CompletedTests()
        {
            return View();
        }

        public ActionResult CreateSummary()
        {
            return View();
        }

        public ActionResult GenerateInvoice()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Approve()
        {
            return View();
        }

        public ActionResult Deny()
        {
            return View();
        }

        public ActionResult PerformanceReports()
        {
            return View();
        }

        public ActionResult ProfitabilityReports()
        {
            return View();
        }

        public ActionResult GenerateQuoteSeattle()
        {
            ViewBag.LTNumber = new SelectList(db.Compounds, "LTNumber", "CompoundDescription");
            return View();
        }

        public ActionResult ViewReportSeattle()
        {
            return View();
        }

        public ActionResult PharmocologyCatalog()
        {
            return View();
        }

        public ActionResult ProtocolNotebook()
        {
            return View();
        }

    }
}