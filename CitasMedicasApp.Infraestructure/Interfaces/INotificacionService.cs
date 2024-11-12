
using CitasMedicasApp.Infraestructure.Models;
using CitasMedicasApp.Infraestructure.Results;

namespace CitasMedicasApp.Infraestructure.Interfaces
{
    internal interface INotificacionService
    {
        Task<NotificationResult> SendEmailLAsyne(EmailModel emailModel);
        Task<NotificationResult> SendSmsAsyne(SmsModel smsModel);
        Task<NotificationResult> SendPushNotification(PushModel pushModel);

    }
}
