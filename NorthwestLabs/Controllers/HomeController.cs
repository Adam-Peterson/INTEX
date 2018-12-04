using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        public bool isAuthenitcated = false;
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

        

    }
}