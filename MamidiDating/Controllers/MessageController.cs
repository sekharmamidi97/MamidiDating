using MamidiDating.DAL;
using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class MessageController : MamidiDatingController
    {
        IMessageDAL messageDAL;

        public MessageController()
        {

        }

        public MessageController(IMessageDAL messageDAL)
        {
            this.messageDAL = messageDAL;
        }

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

        public ActionResult AddMessageInfo()
        {
            return View("Message");
        }

        [HttpPost]
        public ActionResult AddMessageInfo(MessageViewModel message)
        {
            if(ModelState.IsValid)
            {
                if(message.ToUsername == null)
                {
                    message.ToUsername = "";
                }
                if(message.Subject == null)
                {
                    message.Subject = "";
                }
                if(message.Message == null)
                {
                    message.Message = "";
                }
                if(message.FromUsername == null)
                {
                    message.FromUsername = "";
                }
                messageDAL.AddMessageInfo(message);
                return RedirectToAction("MessageSent");
            }
            return View(message);
        }

        public ActionResult MessageSent()
        {
            return View("MessageSent");
        }
    }
}