using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class TablesController : Controller
    {

        [ActionName("tables-basic")]
        public ActionResult tablesbasic()
        {
            return View();
        }
        [ActionName("tables-datatable")]
        public ActionResult tablesdatatable()
        {
            return View();
        }
        [ActionName("tables-editable")]
        public ActionResult tableseditable()
        {
            return View();
        }
        [ActionName("tables-responsive")]
        public ActionResult tablesresponsive()
        {
            return View();
        }

    }
}