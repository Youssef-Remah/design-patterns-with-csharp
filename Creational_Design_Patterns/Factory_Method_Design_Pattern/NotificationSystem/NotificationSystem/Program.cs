using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteCreators;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of notifier (Email, SMS, Push): ");

            string notifierType = Console.ReadLine();

            Console.WriteLine("Enter the notification message: ");

            string notificationMessage = Console.ReadLine();

            ChooseNotifier(notifierType, notificationMessage);
        }

        static void SendNotification(NotifierFactory factory, string notificationMessage)
        {
            INotifier notifier = factory.CreateNotifier();

            notifier.SendNotification(notificationMessage);
        }

        static void ChooseNotifier(string type, string message)
        {
            switch (type.ToLower())
            {
                case "email":
                    SendNotification(new EmailNotifierFactory(), message);
                    break;

                case "sms":
                    SendNotification(new SMSNotifierFactory(), message);
                    break;

                case "push":
                    SendNotification(new PushNotifierFactory(), message);
                    break;

                default:
                    Console.WriteLine("Unknown notifier type.");
                    break;
            }
        }
    }
}
