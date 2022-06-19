using ISDAL.Classes;
using ISData;
using ISWebApp.ViewModels;
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
            var allData = DAL.GetAllToView();

            return Json(allData, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult AddInnovation(Innovation model)
        {
            InnovationDAL DAL = new InnovationDAL();
            var res = DAL.Add(model);
            return Json(res, JsonRequestBehavior.AllowGet);

        }

        public JsonResult DeleteInnovation(int id)
        {
            InnovationDAL DAL = new InnovationDAL();

            var res = DAL.Delete(id, 1);

            return Json(res, JsonRequestBehavior.AllowGet);

        }
    }
}