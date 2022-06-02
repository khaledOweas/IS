using ISData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDAL.Interfaces
{
    public interface BaseInterface<T> where T : class
    {
        bool Add(T model);
        bool Delete(int id);
        T Update(T model);
        List<T> GetAll();
        T GetById(int id);
    }
}
