using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class TasksController : Controller
    {

        [ActionName("tasks-list")]
        public ActionResult taskslist()
        {
            return View();
        }

        [ActionName("tasks-kanban")]
        public ActionResult taskskanban()
        {
            return View();
        }
        [ActionName("tasks-create")]
        public ActionResult taskscreate()
        {
            return View();
        }

    }
}