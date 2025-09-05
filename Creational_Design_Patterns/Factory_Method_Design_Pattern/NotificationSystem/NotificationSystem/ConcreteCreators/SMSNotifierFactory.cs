using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreators
{
    /// <summary>
    /// A concrete factory that creates <see cref="SMSNotifier"/> instances.
    /// </summary>
    /// <remarks>
    /// This class implements the Factory Method by returning an
    /// <see cref="SMSNotifier"/> object.
    /// </remarks>
    internal class SMSNotifierFactory : NotifierFactory
    {
        /// <summary>
        /// Creates and returns a new <see cref="SMSNotifier"/>.
        /// </summary>
        /// <returns>
        /// A new instance of <see cref="SMSNotifier"/>.
        /// </returns>
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
