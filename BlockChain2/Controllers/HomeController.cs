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
<<<<<<< HEAD

        [HttpGet]
        public ActionResult Login()
=======
        [HttpGet]
        public ActionResult Login(string returnUrl)
>>>>>>> 36298c97ce58b6098661f38ddbe0e3c45e04121a
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
<<<<<<< HEAD
            string email = form["Email address"].ToString();
            string password = form["Password"].ToString();

/*            if (email == "purchaser@test.com" && password == "test123")
=======
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();
            if (email == "purchaser@test.com" && password == "test123")
>>>>>>> 36298c97ce58b6098661f38ddbe0e3c45e04121a
            {

            }
            else if (email == "vendor@test.com" && password == "test123")
            {

            }
            FormsAuthentication.SetAuthCookie(email, rememberMe);
            return RedirectToAction("Index", "Home");
<<<<<<< HEAD

=======
>>>>>>> 36298c97ce58b6098661f38ddbe0e3c45e04121a
        }
    }
}