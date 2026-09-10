
using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Providers;
using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Services;




NotificationService service = new NotificationService(new EmailNotification());

service.NotifyUser("Hola este es un mensaje de prueba nuevo curso enviado a tu correo");