using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class LayoutsController : Controller
    {

        [ActionName("layout-vertical")]
        public ActionResult layoutvertical()
        {
            TempData["ModeName"] = Contants.LAYOUT_VERTICAL;
            TempData["WelcomeText"] = "LAYOUT_VERTICAL";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-horizontal")]
        public ActionResult layouthorizontal()
        {
            TempData["ModeName"] = Contants.LAYOUT_HORIZONTAL;
            TempData["WelcomeText"] = "LAYOUT_HORIZONTAL";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-light-sidebar")]
        public ActionResult layoutlightsidebar()
        {
            TempData["ModeName"] = Contants.LAYOUT_LIGHT_SIDEBAR;
            TempData["WelcomeText"] = "LAYOUT_LIGHT_SIDEBAR";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-compact-sidebar")]
        public ActionResult layoutcompactsidebar()
        {
            TempData["ModeName"] = Contants.LAYOUT_COMPACT_SIDEBAR;
            TempData["WelcomeText"] = "LAYOUT_COMPACT_SIDEBAR";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-icon-sidebar")]
        public ActionResult layouticonsidebar()
        {
            TempData["ModeName"] = Contants.LAYOUT_ICON_SIDEBAR;
            TempData["WelcomeText"] = "LAYOUT_ICON_SIDEBAR";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-boxed")]
        public ActionResult layoutboxed()
        {
            TempData["ModeName"] = Contants.LAYOUT_BOXED;
            TempData["WelcomeText"] = "LAYOUTS_BOXED";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-preloader")]
        public ActionResult layoutpreloader()
        {
            TempData["ModeName"] = Contants.LAYOUT_PRELOADER;
            TempData["WelcomeText"] = "LAYOUTS_PRELOADER";
            return RedirectToAction("Index", "Dashboard");
        }

        [ActionName("layout-colored-sidebar")]
        public ActionResult layoutcoloredsidebar()
        {
            TempData["ModeName"] = Contants.LAYOUT_COLORED_SIDEBAR;
            TempData["WelcomeText"] = "LAYOUTS_COLORED_SIDEBAR";
            return RedirectToAction("Index", "Dashboard");
        }

    }
}