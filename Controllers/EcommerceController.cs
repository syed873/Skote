using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class EcommerceController : Controller
    {

        [ActionName("ecommerce-products")]
        public ActionResult ecommerceproducts()
        {
            return View();
        }

        [ActionName("ecommerce-productdetail")]
        public ActionResult ecommerceproductdetail()
        {
            return View();
        }

        [ActionName("ecommerce-orders")]
        public ActionResult ecommerceorders()
        {
            return View();
        }

        [ActionName("ecommerce-customers")]
        public ActionResult ecommercecustomers()
        {
            return View();
        }

        [ActionName("ecommerce-cart")]
        public ActionResult ecommercecart()
        {
            return View();
        }

        [ActionName("ecommerce-checkout")]
        public ActionResult ecommercecheckout()
        {
            return View();
        }

        [ActionName("ecommerce-shops")]
        public ActionResult ecommerceshops()
        {
            return View();
        }

        [ActionName("ecommerce-addproduct")]
        public ActionResult ecommerceaddproduct()
        {
            return View();
        }



    }
}