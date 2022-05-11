using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class ProjectsController : Controller
    {

        [ActionName("projects-grid")]
        public ActionResult projectsgrid()
        {
            return View();
        }

        [ActionName("projects-list")]
        public ActionResult projectslist()
        {
            return View();
        }
        [ActionName("projects-overview")]
        public ActionResult projectsoverview()
        {
            return View();
        }

        [ActionName("projects-create")]
        public ActionResult projectscreate()
        {
            return View();
        }

    }
}