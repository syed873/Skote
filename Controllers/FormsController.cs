﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class FormsController : Controller
    {

        [ActionName("form-advanced")]
        public ActionResult formadvanced()
        {
            return View();
        }
        [ActionName("form-layouts")]
        public ActionResult formlayouts()
        {
            return View();
        }
        [ActionName("form-editors")]
        public ActionResult formeditors()
        {
            return View();
        }
        [ActionName("form-elements")]
        public ActionResult formelements()
        {
            return View();
        }
        [ActionName("form-mask")]
        public ActionResult formmask()
        {
            return View();
        }
        [ActionName("form-repeater")]
        public ActionResult formrepeater()
        {
            return View();
        }
        [ActionName("form-uploads")]
        public ActionResult formuploads()
        {
            return View();
        }
        [ActionName("form-validation")]
        public ActionResult formvalidation()
        {
            return View();
        }
        [ActionName("form-wizard")]
        public ActionResult formwizard()
        {
            return View();
        }
        [ActionName("form-xeditable")]
        public ActionResult formxeditable()
        {
            return View();
        }


    }
}