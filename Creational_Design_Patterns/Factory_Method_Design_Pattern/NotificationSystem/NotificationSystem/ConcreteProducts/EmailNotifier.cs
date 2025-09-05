using NotificationSystem.AbstractProduct;

namespace NotificationSystem.ConcreteProducts
{
    /// <summary>
    /// Represents a concrete notifier that sends notifications via email.
    /// </summary>
    public class EmailNotifier : INotifier
    {
        /// <summary>
        /// Sends an email notification with the specified message.
        /// </summary>
        /// <param name="message">
        /// The content of the notification to be sent via email.
        /// </param>
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
