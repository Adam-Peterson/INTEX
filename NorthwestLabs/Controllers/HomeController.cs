using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwestLabs.Models;


namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();

        public static bool isClientAuthenitcated = false;
        public static bool isSeattleAuthenitcated = false;
        public static bool isSingaporeAuthenitcated = false;
        public string Error = "";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(string Username, string Password)
        {
            if (Username == "Client" && Password == "password")
            {
                return RedirectToAction("Index", "Client");
            }
            else if(Username == "Seattle" && Password == "password")
            {
                return RedirectToAction("Index", "Seattle");
            }
            else if(Username == "Singapore" && Password == "password")
            {
                return RedirectToAction("Index", "Singapore");
            }
            else
            {
                Error = "Username or password is incorrect";
                ViewBag.Error = Error;
                return View();
            }
        }

        public ActionResult CreatePotentialClient()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePotentialClient([Bind(Include = "ClientID,ClientName,ClientAddress,ClientAddressTwo,ClientState,ClientCity,ClientZipCode,DiscountPercentage,ClientPhone,ClientBalance,ClientEmail")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(client);
        }



    }
}