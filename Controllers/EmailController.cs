using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class EmailController : Controller
    {
        [ActionName("email-inbox")]
        public ActionResult emailinbox()
        {
            return View();
        }

        [ActionName("email-read")]
        public ActionResult emailread()
        {
            return View();
        }
    }
}