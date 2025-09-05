using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    /// <summary>
    /// Represents a concrete notifier that sends notifications via SMS.
    /// </summary>
    public class SMSNotifier : INotifier
    {
        /// <summary>
        /// Sends an SMS notification with the specified message.
        /// </summary>
        /// <param name="message">
        /// The content of the notification to be sent via SMS.
        /// </param>
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}
