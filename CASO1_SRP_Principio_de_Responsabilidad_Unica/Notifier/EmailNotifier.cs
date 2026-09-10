using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO1_SRP_Principio_de_Responsabilidad_Unica.Notifier
{
    public class EmailNotifier
    {

        public void SendWelcomeEmail(string email) {

            Console.WriteLine($"mensaje enviado email {email}");


        }
    }
}
