using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssOOP5.Q3.Interface;

namespace AssOOP5.Q3.Classes
{
    internal class SmsNotificationService:INotificationService
    {
        public SmsNotificationService(string recipient, string message)
        {
            this.recipient = recipient;
            this.message = message;
        }
        public SmsNotificationService() { }

        public string recipient { get; set; }
        public string message { get; set; }

        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"this SMS sent to {recipient} and message is {message}");

        }
    }
}
