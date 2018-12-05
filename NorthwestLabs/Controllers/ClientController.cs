using NorthwestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.DAL;
using System.Data.Entity;



namespace NorthwestLabs.Controllers
{
    public class ClientController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();
        public static string sQuote = "";
        // GET: Client
        public ActionResult Index()
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

        public ActionResult PlaceOrder([Bind(Include = "OrderID, ClientID, OrderDate, DueDate, MinQuotedPrice,MaxQuotedPrice,OrderComments,CashAdvance")] WorkOrder workOrder)
        {
            db.WorkOrders.Add(workOrder);
            db.SaveChanges();
            ViewBag.Quote = sQuote;
            return View();
        }

        public ActionResult ViewWorkOrders()
        {
            return View();
        }

        public ActionResult RequestSpecializedReport()
        {
            return View();
        }

        public ActionResult ViewReport()
        {
            return View();
        }

        public ActionResult GetQuote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string compound, DateTime dueDate, string OrderComments, string cashAdvance, bool Assay1 = false, bool Assay1Test3 = false, bool Assay2 = false, bool Assay2Test2 = false, bool Assay2Test3 = false)
        {
            decimal MinQuotedPrice = 0;

            if (Assay1)
            {
                MinQuotedPrice += 25;
                if (Assay1Test3)
                {
                    MinQuotedPrice += 35;
                }
            }

            if (Assay2)
            {
                MinQuotedPrice += 20;
                if (Assay2Test2)
                {
                    MinQuotedPrice += 15;
                }
                if (Assay2Test3)
                {
                    MinQuotedPrice += 85;
                }
            }
            decimal MaxQuotedPrice = MinQuotedPrice * 2;
            DateTime OrderDate = DateTime.Now;
            sQuote = "The cost of running tests on " + compound + " will be between approximately $" + MinQuotedPrice + " and $" + MaxQuotedPrice;
            int ClientID = 2;

            return RedirectToAction("PlaceOrder", new { ClientID, OrderDate, dueDate, MinQuotedPrice, MaxQuotedPrice, OrderComments, cashAdvance});
        }

        public ActionResult PaymentSubmissionConfirmation()
        {
            return View();
        }
    }
}