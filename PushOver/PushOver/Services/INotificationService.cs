using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PushOver.Dto;

namespace PushOver.Services
{
    public interface INotificationService
    {
        void SendNotificationToUser(NotificationDto notificationDto);
    }
}
