

using CitasMedicasApp.Infraestructure.Interfaces;
using CitasMedicasApp.Infraestructure.Models;
using CitasMedicasApp.Infraestructure.Results;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace CitasMedicasApp.Infraestructure.Service
{
    public class EmailSendService : INotificacionService
    {
     
        public async Task<NotificationResult> SendEmailLAsyne(EmailModel emailModel)
        {
            NotificationResult result = new NotificationResult();   
            try
            {
                using (var client = new SmtpClient())
                {
                   client.Host = "";
                   client.Port = 0;
                   client.EnableSsl = true;
                   client.Credentials = new NetworkCredential("user", "pwd");

                    var menssage = new MailMessage(emailModel.From, emailModel.To);
                    menssage.Body = emailModel.Body;
                    menssage.IsBodyHtml = true; 
                    menssage.Subject = emailModel.Subject;  
                        
                    await client.SendMailAsync(menssage);

                }
            }
            catch(Exception ex)
            {
                result.Message = $"Error realizando la notificacion{ ex.Message }";
            }

               return result;

        }

        public Task<NotificationResult> SendPushNotification(PushModel pushModel)
        {
            throw new NotImplementedException();
        }

        public Task<NotificationResult> SendSmsAsyne(SmsModel smsModel)
        {
            throw new NotImplementedException();
        }
    }
}
