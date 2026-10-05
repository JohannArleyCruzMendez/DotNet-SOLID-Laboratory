using CASO8Combinado__LSP___ISP__La_Jerarquía_de_Usuarios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO8Combinado__LSP___ISP__La_Jerarquía_de_Usuarios.Entities
{
    public class Student : IUser
    {
        public void Login()
        {
            Console.WriteLine("usuario estudiante creado");
        }
    }
}
