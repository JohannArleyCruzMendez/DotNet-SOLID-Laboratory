using CASO9_Contenedor_IoC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO9_Contenedor_IoC.Services
{
    public class EmailService : IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine("enviando mensansaje email");
        }
    }
}
