using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlockChain2.Controllers
{
    public class UsersController : Controller
    {

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        // GET: Users
        public ActionResult Register(string email)
        {
            ViewBag.Message = "Your information will be processed. You will recieve an email to finish registration";
            return View();
        }
    }
}