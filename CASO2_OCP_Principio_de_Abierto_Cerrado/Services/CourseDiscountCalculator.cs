using CASO2_OCP_Principio_de_Abierto_Cerrado.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2_OCP_Principio_de_Abierto_Cerrado.Services
{
    class CourseDiscountCalculator 
    {


        // El método recibe la regla (interfaz) y el precio base
        public decimal GenerarDescuento(IStudentDiscount discountRule, decimal price) 
        {

            return discountRule.ApplyDiscount(price);
        
        }

    }


}





        

