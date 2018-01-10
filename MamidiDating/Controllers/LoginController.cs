using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class LoginController : MamidiDatingController
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View("Login");
        }

        public ActionResult ForgotPassword()
        {
            return View("ForgotPassword");
        }

        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordViewModel passwordModel)
        {
            return View("ForgotPassword");
        }

    }
}