using Skote.Services.Master.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Configuration;

using System.Web.UI;
using System.Web.UI.WebControls;
using Skote.Services.Master;
using Skote.edmx;
using Twilio.Rest.Api.V2010.Account;

namespace Skote.Controllers
{
    public class MasterController : Controller
    {
        MasterAppServices _MasterAppServices = new MasterAppServices();
        public ActionResult GetAll()
        {
            MasterListDto master = new MasterListDto();
            return View(master);

        }
        [HttpGet]
       
        public ActionResult ManageMaster()
        {
            using (var context = DbContext.Create())
            {
                var list = _MasterAppServices.GetAll();
                return View(list);
                
            }
        }

        public ActionResult SaveOrder(string name, string address, Order[] order)
        {
            using (var _context = DbContext.Create())
            {
                string result = "Error! Order Is Not Complete!";
                if (name != null && address != null && order != null)
                {
                    var cutomerId = Guid.NewGuid();
                    Customer model = new Customer();
                    model.CustomerId = cutomerId;
                    model.Name = name;
                    model.Address = address;
                    model.OrderDate = DateTime.Now;
                    _context.Customers.Add(model);

                    foreach (var item in order)
                    {
                        var orderId = Guid.NewGuid();
                        Order O = new Order();
                        O.OrderId = orderId;
                        O.ProductName = item.ProductName;
                        O.Quantity = item.Quantity;
                        O.Price = item.Price;
                        O.Amount = item.Amount;
                        O.CustomerId = cutomerId;
                        _context.Orders.Add(O);
                    }
                    _context.SaveChanges();
                    result = "Success! Order Is Complete!";
                }


                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult SendMessageToUser()
        {
            try
            {
                 

                Twilio.TwilioClient.Init("AC0efa5013ca9785cf20797f0f5e88ff8c", "1a23b3b1f15965c99397e669da39052f");
                MessageResource.Create(
               body: $"Hello Ali",
               from: "+18144812760",
               to: new Twilio.Types.PhoneNumber("+92 3409418488"));

                return Json("Success");

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
  
}