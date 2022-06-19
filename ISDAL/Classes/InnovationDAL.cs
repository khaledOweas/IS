using ISDAL.Interfaces;
using ISData;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ISDAL.ViewModels;

namespace ISDAL.Classes
{
    public class InnovationDAL : IInnovationInterface
    {
        ISDB db;
        public InnovationDAL()
        {
            db = new ISDB();
        }
        public bool Add(Innovation model)
        {
            db.Innovations.Add(model);
            return db.SaveChanges() > 0;
        }

        public string Delete(int id, int userid)
        {

            var model = db.Innovations.FirstOrDefault(x => x.Id == id);

            if (model != null)
            {
                if (model.CreatedUserId == userid)
                {

                    db.Innovations.Remove(model);
                    var data = db.SaveChanges() > 0;
                    if (data)
                    {
                        return " Delete Success";
                    }
                    else
                    {
                        return "Failed To Delte ";
                    }
                }
                else
                {
                    return "You don't have permission to delete this innovation";
                }
            }
            else
            {
                return $"there is no Innovation With Id {id.ToString()}";
            }
        }

        public List<Innovation> GetAll()
        {
            return db.Innovations.ToList();
        }
        public List<InnovationViewModel> GetAllToView()
        {
            return db.Innovations
                .Include(x => x.CreatedUser)
                .AsNoTracking()
                .Select(x => new InnovationViewModel()
                {
                    Id= x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    UserName = x.CreatedUser.Name,
                    CreatedUserId = x.CreatedUserId
                }).ToList();
        }

        public Innovation GetById(int id) => db.Innovations.Find(id);

        public Innovation Update(Innovation model)
        {
            Innovation OldInvo = db.Innovations.FirstOrDefault(x => x.Id == model.Id);
            OldInvo.Title =  model.Title;
            OldInvo.Description = model.Description;
            // Mapping  ... >>> > >> > > > >> > > > > Auto Mapper .. 
            int res = db.SaveChanges();
            if (res > 0)
            {
                return OldInvo;
            }
            else
            {
                return null;
            }
        }


        public Innovation GetFirstInnovation() => db.Innovations.First();

    }
}
