using MamidiDating.DAL;
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
        private IContactDAL contactDAL;

        public ContactController()
        {

        }

        public ContactController(IContactDAL contactDAL)
        {
            this.contactDAL = contactDAL;
        }

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

        public ActionResult AddContactMessageInfo()
        {
            return View("Contact");
        }

        [HttpPost]
        public ActionResult AddContactMessageInfo(ContactViewModel newInfo)
        {
            if (ModelState.IsValid)
            {
                if (newInfo.FirstName == null)
                {
                    newInfo.FirstName = "";
                }
                if (newInfo.LastName == null)
                {
                    newInfo.LastName = "";
                }
                if (newInfo.EmailAddress == null)
                {
                    newInfo.EmailAddress = "";
                }
                if (newInfo.ContactReason == null)
                {
                    newInfo.ContactReason = "";
                }
                if (newInfo.Message == null)
                {
                    newInfo.Message = "";
                }
                contactDAL.AddContactMessageInfo(newInfo);
                return RedirectToAction("Thanks");
            }
            return View(newInfo);
        }

        public ActionResult Thanks()
        {
            return View("Thanks");
        }
    }
}