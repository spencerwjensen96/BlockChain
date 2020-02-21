using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlockChain2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "How it all works";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            string email = form["Email address"].ToString();
            string password = form["Password"].ToString();

/*          if (email == "purchaser@test.com" && password == "test123")

            {

            }
            else if (email == "vendor@test.com" && password == "test123")
            {

            }*/
            FormsAuthentication.SetAuthCookie(email, rememberMe);
            return RedirectToAction("Index", "Home");

        }
    }
}