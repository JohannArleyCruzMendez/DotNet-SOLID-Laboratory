using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampTech.Domain
{
    public class Bootcamp
    {
       public int BootcampId { get; set; }
       
       public string Name { get; set; } = string.Empty;
      
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
