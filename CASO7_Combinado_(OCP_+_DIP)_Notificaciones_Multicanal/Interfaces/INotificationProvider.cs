using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Interfaces
{
    public interface INotificationProvider
    {
        void Send(string message);
    }
}
