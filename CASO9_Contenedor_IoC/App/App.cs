using CASO9_Contenedor_IoC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO9_Contenedor_IoC.App
{
    public class App
    {
        private readonly IMessageService _messageServic;

        public App(IMessageService messageServic)
        {
            _messageServic = messageServic;
        }

        public void Run() {

            _messageServic.SendMessage();
        
        
        }

    }
}
