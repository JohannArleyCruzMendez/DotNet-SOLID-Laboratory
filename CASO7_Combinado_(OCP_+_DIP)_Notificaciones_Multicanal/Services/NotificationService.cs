using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Services
{
    public class NotificationService
    {
        private readonly INotificationProvider _notificationProvider;

        public NotificationService(INotificationProvider notificationProvider)
        {
            _notificationProvider = notificationProvider;
        }

        public void NotifyUser(string message) 
        
        {
             _notificationProvider.Send(message); 
        
               
        }



    }

}
