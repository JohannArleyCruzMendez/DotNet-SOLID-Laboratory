using CASO10_El_Reto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO10_El_Reto_Final.Implementations
{
    public class EmailChannel : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine($"Enviando email: {message}");
        }
    }
}
