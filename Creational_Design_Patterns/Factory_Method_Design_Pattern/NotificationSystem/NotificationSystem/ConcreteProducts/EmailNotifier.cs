using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
