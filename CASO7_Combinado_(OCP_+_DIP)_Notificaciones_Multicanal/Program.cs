
using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Providers;
using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Services;




NotificationService service = new NotificationService(new EmailNotification());

service.NotifyUser("un saludo y animo que si se puede ");