using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
