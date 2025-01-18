using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP5.Q3.Interface
{
    internal interface INotificationService
    {
        public string message { get; set; }
        public string recipient { get; set; }
        public void SendNotification(string recipient ,string message)
        { 
        }
    }
}
