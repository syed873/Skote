using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class IconsController : Controller
    {

        [ActionName("icons-boxicons")]
        public ActionResult iconsboxicons()
        {
            return View();
        }
        [ActionName("icons-dripicons")]
        public ActionResult iconsdripicons()
        {
            return View();
        }
        [ActionName("icons-fontawesome")]
        public ActionResult iconsfontawesome()
        {
            return View();
        }
        [ActionName("icons-materialdesign")]
        public ActionResult iconsmaterialdesign()
        {
            return View();
        }

    }
}