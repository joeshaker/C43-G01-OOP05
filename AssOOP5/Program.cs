using AssOOP5.Q1.Classes;
using AssOOP5.Q2.Classes;
using AssOOP5.Q2.Enum;
using AssOOP5.Q2.Interfaces;
using AssOOP5.Q3.Classes;
using AssOOP5.Q3.Interface;

namespace AssOOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Circle c1 = new Circle();
            //c1.Area = 10;
            //c1.DisplayShapeInfo();
            //Rectangle r1 = new Rectangle();
            //r1.Area = 100;
            //r1.DisplayShapeInfo(); 
            #endregion
            #region Q2
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //BasicAuthenticationService b1 = new BasicAuthenticationService("admin", "admin123",Roles.User);
            //BasicAuthenticationService b2 = new BasicAuthenticationService();
            //b2.Username = "User";
            //b2.Password = "45455";
            //Roles role;
            //Enum.TryParse<Roles>(Console.ReadLine(),out role);
            //b2.Role = role;
            //bool _IsAuth = authenticationService.AuthenticateUser(b1);
            //Console.WriteLine(_IsAuth ? "Authentication Succssesfully" : "Authentication Failed");
            //bool _IsAthor = authenticationService.AuthorizeUser(b2);
            //Console.WriteLine(_IsAthor);
            //Console.WriteLine(_IsAthor ? "Authorization Succssesfully" : "Authorization Failed");
            //Console.WriteLine(b2.Role);
            //_IsAthor = authenticationService.AuthorizeUser(b1);
            //Console.WriteLine(_IsAthor);
            //Console.WriteLine(_IsAthor ? "Authorization Succssesfully" : "Authorization Failed");
            #endregion
            #region Q3
            //EmailNotificationService e1=new EmailNotificationService("Youssef","Welcome to our company");
            //e1.SendNotification(e1.recipient,e1.message);
            //INotificationService Emailnotify=new EmailNotificationService();
            //INotificationService SMSnotify= new SmsNotificationService();
            //INotificationService notification=new PushNotificationService();

            //string person = "Ali Ahmed";
            //string message = "Complete Succssesfully";
            //Emailnotify.SendNotification(person, message);
            //SMSnotify.SendNotification(person, message);
            //notification.SendNotification(person, message); 
            #endregion







        }
    }
}
