using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit; // Se instala con MailKit
using MailKit.Net.Smtp; // Se instala con MailKit



namespace CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Providers
{
    public class EmailNotification : INotificationProvider
    {
        public void Send(string message)
        {
            // 1. Configura tus datos reales (Usa tu correo emisor de Gmail)
            string correoEmisor = "jocrme@gmail.com";
            string contrasenaSegura = "atlttbdxkynedhlj"; // Tu clave de 16 letras activa

            // 2. Crear el objeto del mensaje usando MimeKit
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Sistema SOLID", correoEmisor));
            email.To.Add(new MailboxAddress("Destinatario", "jocrme@gmail.com")); // Tu correo de destino
            email.Subject = "🚨 Notificación en Tiempo Real - MailKit C#";

            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = message
            };

            // 3. Enviar usando el cliente moderno de MailKit
            using (var client = new SmtpClient())
            {
                try
                {
                    // Conexión SSL pura y directa en el puerto 465
                    client.Connect("smtp.gmail.com", 465, MailKit.Security.SecureSocketOptions.SslOnConnect);

                    // Autenticar con tus credenciales de Google
                    client.Authenticate(correoEmisor, contrasenaSegura);

                    // Enviar correo real a internet
                    client.Send(email);

                    Console.WriteLine("\n[Email] ¡Éxito total con MailKit! El correo ya está en tu bandeja de entrada.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[MailKit Error] Falló el envío: {ex.Message}");
                }
                finally
                {
                    // Desconectarse limpiamente del servidor
                    client.Disconnect(true);
                }
            }
        }
    }

}





