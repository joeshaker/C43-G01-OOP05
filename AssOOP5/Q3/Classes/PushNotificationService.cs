using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP5.Q3.Interface;

namespace AssOOP5.Q3.Classes
{
    internal class PushNotificationService:INotificationService
    {
        public PushNotificationService(string recipient, string message)
        {
            this.recipient = recipient;
            this.message = message;
        }
        public PushNotificationService() { }

        public string recipient { get; set; }
        public string message { get; set; }


        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push Notification sent to {recipient} and message is {message}");

        }
    }
}
