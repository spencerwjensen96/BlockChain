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
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Farmer()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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

            if (email == "farmer@test.com" && password == "test123")
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Farmer", "Home");
            }
            else if (email == "vendor@test.com" && password == "test123")
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.LoginMessage = "Incorrect username or password";
            return View();

        }
    }
}