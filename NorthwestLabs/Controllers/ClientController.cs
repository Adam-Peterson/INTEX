using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class ClientController : Controller
    {
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

        public ActionResult PlaceOrder()
        {
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
        public ActionResult GetQuote(string compound, bool Assay1 = false, bool Assay1Test3 = false, bool Assay2 = false, bool Assay2Test2 = false, bool Assay2Test3 = false)
        {
            decimal Price = 0;

            if (Assay1)
            {
                Price += 25;
                if (Assay1Test3)
                {
                    Price += 35;
                }
            }

            if (Assay2)
            {
                Price += 20;
                if (Assay2Test2)
                {
                    Price += 15;
                }
                if (Assay2Test3)
                {
                    Price += 85;
                }
            }

            sQuote = "The cost of running tests on " + compound + " will be between approximately $" + Price + " and $ " + Price * 2;
            return RedirectToAction("PlaceOrder");
        }

        public ActionResult PaymentSubmissionConfirmation()
        {
            return View();
        }
    }
}