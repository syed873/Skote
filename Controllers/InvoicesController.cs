using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class InvoicesController : Controller
    {

        [ActionName("invoices-detail")]
        public ActionResult invoicesdetail()
        {
            return View();
        }

        [ActionName("invoices-list")]
        public ActionResult invoiceslist()
        {
            return View();
        }

    }
}