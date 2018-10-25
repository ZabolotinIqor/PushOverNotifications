using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PushOver.Dto;
using PushOver.Services;

namespace PushOver.Controllers
{

    [Route("api/notify")]
    public class NotificationController:Controller
    {
        private readonly INotificationService notificationService;

        public NotificationController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        [HttpPost]
        public IActionResult NotifyApp([FromBody]NotificationDto notifyDto)
        {
            notificationService.SendNotificationToUser(notifyDto);
            return Ok();
        }

    }
}
