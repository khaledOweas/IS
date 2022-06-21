using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISData
{
    public class Innovation
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("CreatedUser")]
        public int CreatedUserId { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual Category InnovationCategory { get; set; }

    }
}