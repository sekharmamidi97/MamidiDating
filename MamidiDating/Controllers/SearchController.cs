using MamidiDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class SearchController : MamidiDatingController
    {
        // GET: Search
        public ActionResult UsernameSearch()
        {
            return View("UsernameSearch");
        }

        [HttpPost]
        public ActionResult UsernameSearch(UsernameSearchViewModel model)
        {
            return View("UsernameSearch");
        }

        public ActionResult BasicSearch()
        {
            return View("BasicSearch");
        }

        [HttpPost]
        public ActionResult BasicSearch(BasicSearchViewModel model)
        {
            return View("BasicSearch");
        }

        public ActionResult AdvancedSearch()
        {
            return View("AdvancedSearch");
        }

        [HttpPost]
        public ActionResult AdvancedSearch(AdvancedSearchViewModel model)
        {
            return View("AdvancedSearch");
        }
    }
}