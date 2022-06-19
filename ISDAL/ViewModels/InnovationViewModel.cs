using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDAL.ViewModels
{
    public class InnovationViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int CreatedUserId { get; set; }
        public string UserName { get; set; }
    }
}
