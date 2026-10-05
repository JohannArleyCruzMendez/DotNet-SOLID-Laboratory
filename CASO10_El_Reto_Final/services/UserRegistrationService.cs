using CASO10_El_Reto_Final.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO10_El_Reto_Final.services
{
    public class UserRegistrationService
    {
       private readonly INotificationChannel _notificationChannel;
       private readonly IUserRepository _userRepository;

        public UserRegistrationService(INotificationChannel notificationChannel, IUserRepository userRepository)
        {
            _notificationChannel = notificationChannel;
            _userRepository = userRepository;
        }


        public void Register(string name ,string message) {

           
            
               _userRepository.Save(name);
            _notificationChannel.Send(message);
         
        
        
        }
    
    
    
    
    
    }
}
