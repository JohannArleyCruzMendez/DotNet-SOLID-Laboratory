using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO3_LSP_Principio_de_Sustitución_de_Liskov.Entities
{
    public abstract class Course
    {

        public string Title { get; set; } = string.Empty;

        public abstract void ShowDetails();
    }
}
