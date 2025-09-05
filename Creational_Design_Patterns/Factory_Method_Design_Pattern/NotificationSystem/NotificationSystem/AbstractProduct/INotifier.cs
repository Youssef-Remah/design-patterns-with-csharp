namespace NotificationSystem.AbstractProduct
{
    /// <summary>
    /// Defines the contract for notifier objects that can send notifications.
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// Sends a notification with the specified message.
        /// </summary>
        /// <param name="message">
        /// The content of the notification to be sent.
        /// </param>
        public void SendNotification(string message);
    }
}
