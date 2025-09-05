using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    /// <summary>
    /// Represents a concrete notifier that sends notifications via push messages.
    /// </summary>
    public class PushNotifier : INotifier
    {
        /// <summary>
        /// Sends a push notification with the specified message.
        /// </summary>
        /// <param name="message">
        /// The content of the notification to be sent via push notification.
        /// </param>
        public void SendNotification(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
