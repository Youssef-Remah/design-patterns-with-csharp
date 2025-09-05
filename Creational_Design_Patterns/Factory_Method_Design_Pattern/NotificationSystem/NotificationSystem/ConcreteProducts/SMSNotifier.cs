using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    public class SMSNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}
