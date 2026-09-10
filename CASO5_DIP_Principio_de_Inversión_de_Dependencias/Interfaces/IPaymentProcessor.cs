using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO5_DIP_Principio_de_Inversión_de_Dependencias.Interfaces
{
     public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);

    }
}
