using CASO5_DIP_Principio_de_Inversión_de_Dependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO5_DIP_Principio_de_Inversión_de_Dependencias.Processors
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Procesando pago de {amount} usando Paypal...");

        }
    }
}
