using CASO10_El_Reto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO10_El_Reto_Final.Repository
{
    public class SqlUserRepository : IUserRepository
    {
        public void Save(string Name)
        {
            Console.WriteLine($"Guardando a {Name} en la BD...");
        }
    }
}
