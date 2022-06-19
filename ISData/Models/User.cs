using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ISData
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Innovation> CreatedInnovations { get; set; }

    }
}