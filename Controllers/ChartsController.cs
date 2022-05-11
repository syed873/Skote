using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class ChartsController : Controller
    {

        [ActionName("charts-apex")]
        public ActionResult chartsapex()
        {
            return View();
        }
        [ActionName("charts-echart")]
        public ActionResult chartsechart()
        {
            return View();
        }
        [ActionName("charts-chartjs")]
        public ActionResult chartschartjs()
        {
            return View();
        }
        [ActionName("charts-flot")]
        public ActionResult chartsflot()
        {
            return View();
        }
        [ActionName("charts-knob")]
        public ActionResult chartsknob()
        {
            return View();
        }
        [ActionName("charts-sparkline")]
        public ActionResult chartssparkline()
        {
            return View();
        }
        [ActionName("charts-tui")]
        public ActionResult chartstui()
        {
            return View();
        }

    }
}