
using CitasMedicasApp.Infraestructure.Interfaces;
using CitasMedicasApp.Infraestructure.Models;
using CitasMedicasApp.Infraestructure.Results;
using Newtonsoft.Json;
using System.Text;

namespace CitasMedicasApp.Infraestructure.Service
{
    public class SmsService : INotificacionService
    {
        private readonly HttpClient httpClient;

        public SmsService(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public Task<NotificationResult> SendEmailLAsyne(EmailModel emailModel)
        {
            throw new NotImplementedException();
        }

        public async Task<NotificationResult> SendPushNotification(PushModel pushModel)
        {
            throw new NotImplementedException();

        }

        public async Task<NotificationResult> SendSmsAsyne(SmsModel smsModel)
        {
            NotificationResult result = null;

            try
            {
                var httpClient = new HttpClient();

                var contect = new StringContent(JsonConvert.SerializeObject(smsModel),Encoding.UTF8,"application/json");

                await httpClient.PostAsync("miurl",contect);
            }
            catch (Exception)
            {
                throw;
            }

            return result;


        }

      
    }
}
