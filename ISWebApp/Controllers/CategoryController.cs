using ISDAL.Classes;
using ISData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISWebApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {  
            CategoryDAL DAL =new CategoryDAL();
              var All=DAL.GetAll();
            return Json(All);

        }

        public JsonResult addCategory(Category model)
        {
            CategoryDAL DAL =new CategoryDAL();
            var AddedItem = DAL.Add(model);
                return Json(AddedItem);
        }
        public JsonResult DeleteCategory(int id,int userid)
        {
            CategoryDAL categoryDAL =new CategoryDAL();
           var DeletedItem =categoryDAL.Delete(id,userid);
            return Json(DeletedItem);
        }
        public JsonResult Updatecategory (Category model)
        {
            CategoryDAL dAL =new CategoryDAL();
           Category UpdatedItem = dAL.Update(model);
            return Json (UpdatedItem);
        }

    }
}