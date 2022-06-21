using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISData;

namespace ISDAL.Interfaces
{
    public interface ICategoryInterface : BaseInterface<Category>
    {
        Category Getfirst();
     

    }
}
