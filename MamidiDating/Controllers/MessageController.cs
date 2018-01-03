using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Message()
        {
            return View("Message");

        }

        [HttpPost]
        public ActionResult Message(MessageViewModel model)
        {
            return View("Message");
        }

        public ActionResult MessageSent()
        {
            return View("MessageSent");
        }
    }
}