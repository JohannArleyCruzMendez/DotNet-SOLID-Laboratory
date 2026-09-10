using CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Types;


namespace CASO7_Combinado__OCP___DIP__Notificaciones_Multicanal.Providers
{
    public class SmsNotification : INotificationProvider
    {
        public void Send(string message)
        {
            // Método seguro para leer variables creadas con setx en Windows
            string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID", EnvironmentVariableTarget.User);
            string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN", EnvironmentVariableTarget.User);

            if (string.IsNullOrEmpty(accountSid) || string.IsNullOrEmpty(authToken))
            {
                Console.WriteLine("[Error] No se encontraron las variables de entorno. ¿Reiniciaste Visual Studio?");
                return;
            }

            TwilioClient.Init(accountSid, authToken);

            try
            {
                var mensajeSms = Twilio.Rest.Api.V2010.Account.MessageResource.Create(
                    body: "Appointment reminder: Your appointment is scheduled for tomorrow.",
                    from: new PhoneNumber("+17372508034"),
                    to: new PhoneNumber("+573186573095")
                );

                Console.WriteLine($"\n[Twilio API] ¡Conexión Exitosa Real! SID: {mensajeSms.Sid}");
                Console.WriteLine("[SMS] Mensaje enviado a tu celular. ¡Revisa tu bandeja de texto!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Twilio Error] Falló el envío del SMS real: {ex.Message}");
            }
        }
    }
    }


