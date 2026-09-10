using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO3_LSP_Principio_de_Sustitución_de_Liskov.Entities
{
    public class InPersonCourse : Course
    {
        public override void ShowDetails() => Console.WriteLine($"Curso Presencial: {Title}");



    }
}
