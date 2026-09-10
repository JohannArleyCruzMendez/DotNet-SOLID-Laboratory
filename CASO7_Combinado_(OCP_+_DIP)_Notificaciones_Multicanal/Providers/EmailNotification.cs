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
            // 1. Configura tus datos reales
            string correoEmisor = "jocrme@gmail.com";

            // 🚨 EL CAMBIO: Leemos la clave desde Windows.
            string contrasenaSegura = Environment.GetEnvironmentVariable("MAIL_PASSWORD", EnvironmentVariableTarget.User);

            if (string.IsNullOrEmpty(contrasenaSegura))
            {
                Console.WriteLine("[Error] No se encontró la contraseña en las variables de entorno.");
                return; // Detiene el envío para que la app no explote
            }

            // 2. Crear el objeto del mensaje usando MimeKit
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Sistema SOLID", correoEmisor));
            email.To.Add(new MailboxAddress("Destinatario", "jocrme@gmail.com"));
            email.Subject = "🚨 Notificación en Tiempo Real - MailKit C#";

            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = message
            };

            // 3. Enviar el correo (Asegúrate de tener este bloque al final de tu método)
            using var client = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate(correoEmisor, contrasenaSegura);
                client.Send(email);
                Console.WriteLine("[Email] ¡Éxito total con MailKit! El correo ya está en tu bandeja de entrada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Email Error] Falló el envío: {ex.Message}");
            }
            finally
            {
                client.Disconnect(true);
            }
        }
    }

}





