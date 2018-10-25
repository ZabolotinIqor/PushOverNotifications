using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PushOver.Dto
{
    public class NotificationDto
    {

        /// <summary>
        /// Not good practice.
        /// </summary>
        public string APP_TOKEN { get; set; } = "a1qmygfomopvh5coaijzf31r3iohc3";

        public string USER_KEY { get; set; }

        public string message { get; set; }

    }
}
