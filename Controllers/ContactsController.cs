using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class ContactsController : Controller
    {

        [ActionName("contacts-grid")]
        public ActionResult contactsgrid()
        {
            return View();
        }

        [ActionName("contacts-list")]
        public ActionResult contactslist()
        {
            return View();
        }
        [ActionName("contacts-profile")]
        public ActionResult contactsprofile()
        {
            return View();
        }

    }
}