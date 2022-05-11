using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class CryptoController : Controller
    {
        //// GET: Crypto
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [ActionName("crypto-wallet")]
        public ActionResult cryptowallet()
        {
            return View();
        }
        [ActionName("crypto-buy-sell")]
        public ActionResult cryptobuysell()
        {
            return View();
        }
        [ActionName("crypto-exchange")]
        public ActionResult cryptoexchange()
        {
            return View();
        }
        [ActionName("crypto-lending")]
        public ActionResult cryptolending()
        {
            return View();
        }
        [ActionName("crypto-orders")]
        public ActionResult cryptoorders()
        {
            return View();
        }
        [ActionName("crypto-kyc-application")]
        public ActionResult cryptokycapplication()
        {
            return View();
        }
        [ActionName("crypto-ico-landing")]
        public ActionResult cryptoicolanding()
        {
            return View();
        }


    }
}