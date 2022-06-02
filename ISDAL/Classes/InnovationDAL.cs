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

        public bool Delete(int id)
        {
            db.Innovations.Remove(db.Innovations.FirstOrDefault(x => x.Id == id));
            return db.SaveChanges() > 0;
        }

        public List<Innovation> GetAll() => db.Innovations.ToList();
        public Innovation GetById(int id) => db.Innovations.Find(id);
        public Innovation GetFirstInnovation() => db.Innovations.First();

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
    }
}
