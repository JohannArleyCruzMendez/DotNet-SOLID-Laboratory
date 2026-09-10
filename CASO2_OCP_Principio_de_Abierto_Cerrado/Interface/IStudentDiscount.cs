using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2_OCP_Principio_de_Abierto_Cerrado.Interface
{
     public interface IStudentDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}
