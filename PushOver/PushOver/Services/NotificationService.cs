using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using PushOver.Dto;

namespace PushOver.Services
{
    public class NotificationService:INotificationService
    {


        public void SendNotificationToUser(NotificationDto notificationDto)
        {
            var parameters = new NameValueCollection {
                { "token", notificationDto.APP_TOKEN },
                { "user", notificationDto.USER_KEY },
                { "message", notificationDto.message }
            };

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }
        }
    }
}
