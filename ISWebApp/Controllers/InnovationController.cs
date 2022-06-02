using ISDAL.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISWebApp.Controllers
{
    public class InnovationController : Controller
    {
        // GET: Innovation
        public ActionResult Index()
        {
            return View();
        } 


        public JsonResult GetAllInnovations()
        {
            InnovationDAL DAL = new InnovationDAL();
            var allData = DAL.GetAll();
            // JsonRequestBehavior.AllowGet  >>  To Avoid Block Json .. 
            return Json(allData, JsonRequestBehavior.AllowGet);
        }
    }
}