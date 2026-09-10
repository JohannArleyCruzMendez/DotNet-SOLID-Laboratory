using CASO1_SRP_Principio_de_Responsabilidad_Unica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO1_SRP_Principio_de_Responsabilidad_Unica.Repository
{
    public class StudentRepository

     {

             

        public void Save(Student student) { 
        
        
           Console.WriteLine($"studiante guardado nombre y correo {student.FirstName}{student.LastName}{student.Email}");
        
        
        }


      }

}
