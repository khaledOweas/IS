using ISDAL.Interfaces;
using ISData;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ISDAL.ViewModels;



namespace ISDAL.Classes
{
    public class CategoryDAL : ICategory
    {
        ISDB db;
        public CategoryDAL()
        {
            db = new ISDB();
        }
        public bool Add(Category model)
        {
         
            db.Categories.Add(model);
            return db.SaveChanges() > 0;

        }

        public string Delete(int id, int userid)
        {
            var deleted = db.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (deleted == null) { db.Categories.Remove(deleted); }
            return "Deleted successfully";
        }

        public List<Category> GetAll()
        {
           return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public Category Getfirst()
        {
            throw new System.NotImplementedException();
        }

        public Category Update(Category model)
        {
           Category category= db.Categories.FirstOrDefault(x => x.CategoryId == model.CategoryId);
          category.Name = model.Name;
            return category;
            
        }
    }
}
