using CASO2_OCP_Principio_de_Abierto_Cerrado.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2_OCP_Principio_de_Abierto_Cerrado.Discounts
{
    public class PremiumDiscount : IStudentDiscount
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price*0.8m;
        }
    }
}
