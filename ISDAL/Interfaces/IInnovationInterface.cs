using ISDAL.ViewModels;
using ISData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDAL.Interfaces
{

    // !!!!!! WHY  ..  To Adding Customize Function For Every Entity   !!!!!! 
    public interface IInnovationInterface : BaseInterface<Innovation>
    {
        Innovation GetFirstInnovation();
        List<InnovationViewModel> GetAllToView();
    }
}
