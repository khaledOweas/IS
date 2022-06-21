using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ISData
{
    public class Category
    {
        [Key]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Innovation> CreatedInnovations { get; set; }

    }
}
