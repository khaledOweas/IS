using ISDAL.Interfaces;
using ISData;
using System.Collections.Generic;
using System.Linq;

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
                if (model.CreatedBy == userid)
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

        public List<Innovation> GetAll() => db.Innovations.ToList();
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
