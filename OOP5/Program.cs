using OOP5.Q1;
using OOP5.Q2;
using OOP5.Q3;

namespace OOP5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("CIRCLE INFO: ");

            //Icircle circle = new Circle();
            //circle.Radius = 10;
            //circle.DisplayShapeInfo();
            //Console.WriteLine("\nRECTANGLE INFO: ");
            //Irectangle rectangle = new Rectangle(10, 20);
            //rectangle.DisplayShapeInfo();

            #endregion
            #region Q2

            //IAuthenticationService authService = new BasicAuthenticationService();
            //string username = "ahmed";
            //string password = "54321moh";
            //Console.WriteLine("AFTER adding WRONG password :");
            //if (authService.AuthenticateUser(username, password))
            //     Console.WriteLine($"The user with username {username} is authenicated");
            //else
            //     Console.WriteLine($"The user with username {username} is not authenicated");
            //password = "ahm12345";
            //Console.WriteLine("\nAFTER adding the CORRECT password :");
            //if (authService.AuthenticateUser(username, password))
            //     Console.WriteLine($"The user with username {username} is authenicated");
            //else
            //     Console.WriteLine($"The user with username {username} is not authenicated");
            //username = "ahmed";
            //string role = "user";
            //Console.WriteLine("\n\nAFTER adding role he doesn't have :");
            //if (authService.AuthorizeUser(username, role))
            //    Console.WriteLine($"The user with username {username} does have this role {role}");
            //else
            //    Console.WriteLine($"The user with username {username} doesn't have this role {role}");
            //role = "admin";
            //Console.WriteLine("\nAFTER adding rule he has :");
            //if (authService.AuthorizeUser(username, role))
            //    Console.WriteLine($"The user with username {username} does have this role {role}");
            //else
            //    Console.WriteLine($"The user with username {username} doesn't have this role {role}");

            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("ahmedelkhouly@gmail.com", "This is an email notification.");
            smsService.SendNotification("01020545096", "This is an SMS notification.");
            pushService.SendNotification("User123", "This is a push notification.");
            #endregion
        }
    }
}

