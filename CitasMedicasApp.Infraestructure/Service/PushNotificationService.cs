

using CitasMedicasApp.Infraestructure.Interfaces;
using CitasMedicasApp.Infraestructure.Models;
using CitasMedicasApp.Infraestructure.Results;

namespace CitasMedicasApp.Infraestructure.Service
{
    public class PushNotificationService : INotificacionService
    {
        public Task<NotificationResult> SendEmailLAsyne(EmailModel emailModel)
        {
            throw new NotImplementedException();
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
