using CASO5_DIP_Principio_de_Inversión_de_Dependencias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO5_DIP_Principio_de_Inversión_de_Dependencias.Services
{
    public class CourseCheckoutService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public CourseCheckoutService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }


        public void ProcessCheckout(decimal amount) { 
        
           
           _paymentProcessor.ProcessPayment(amount);  
        
        }




    }
}
