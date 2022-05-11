using ClosedXML.Excel;
using Skote.edmx;
using Skote.Helper;
using Skote.Services.Person.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using PagedList;

namespace Skote.Controllers
{
    public class PersonController : Controller
    {


        PersonAppServices _personAppServices = new PersonAppServices();

        [HttpGet]
        public ActionResult GetAll()
        {
            PersonListDto person = new PersonListDto();
            return View(person);
        }

        [HttpGet]
        public  ActionResult CreateUpdatePerson()
        {
            PersonEditDto model = new PersonEditDto();
            ViewBag.LogoIsNull = true;
            model.GenderList = _personAppServices.GetGenderCombo().Select(a => new SelectListItem { Text = a.DisplayText, Value = a.Value.ToString() }).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateUpdatePerson(PersonEditDto model, HttpPostedFileBase file)
        {
            var CompanylogoUrl = WebConfigurationManager.AppSettings["PersonLogo"];
            var image = UploadHelper.UploadImage(file, CompanylogoUrl);
            var Companylogothumb = WebConfigurationManager.AppSettings["PersonLogoThumb"];
            var logothumbnail = UploadHelper.Thumbnail(file, Companylogothumb);
            if (image != null)
            {
                model.Image = image;
            }
            _personAppServices.CreateUpdatePerson(model);
            return RedirectToAction("ManagePlayer");
        }

        public ActionResult ManagePlayer()
        {
            
                    var list = _personAppServices.GetAll();
                return View(list);
           
            
        }
        public JsonResult DeletePerson(int id = 0)
        {
         
            _personAppServices.DeletePerson(id);
            return Json(JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult EditPerson(int id=0)
        {
            PersonEditDto person = new PersonEditDto();
            ViewBag.ImageIsNull = true;
            person = _personAppServices.GetPersonForEdit(id);

            person.GenderList = _personAppServices.GetGenderCombo().Select(a => new SelectListItem { Text = a.DisplayText, Value = a.Value.ToString() }).ToList();
            return View("CreateUpdatePerson",null,person);
        
        }

       
        public ActionResult PrintAllPerson()
        {
            var report = new Rotativa.ActionAsPdf("ManagePlayer");
            
            return report;
        }

      


        public ActionResult ExcelConvert(int ? page)
        {
            
            return View(this.GetAll());
        }
        public ActionResult ExportToExcel()
        {

            var gv = new GridView();
            gv.DataSource = _personAppServices.GetAll();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=DemoExcel.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
           
            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return View("ExcelConvert");
        }
    }
}




