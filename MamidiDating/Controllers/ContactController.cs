using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View("Contact");
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            return View("Contact");
        }

        public ActionResult Thanks()
        {
            return View("Thanks");
        }
    }
}