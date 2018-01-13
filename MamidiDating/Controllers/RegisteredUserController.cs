using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class RegisteredUserController : Controller
    {
        // GET: RegisteredUser
        public ActionResult RegisteredUser()
        {
            return View("RegisteredUser");
        }

        [HttpPost]
        public ActionResult RegisteredUser(RegisteredUserViewModel model)
        {
            return View("RegisteredUser");
        }
    }
}