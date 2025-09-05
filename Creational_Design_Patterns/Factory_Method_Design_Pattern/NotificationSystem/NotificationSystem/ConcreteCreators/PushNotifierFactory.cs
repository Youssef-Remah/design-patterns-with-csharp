using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreators
{
    /// <summary>
    /// A concrete factory that creates <see cref="PushNotifier"/> instances.
    /// </summary>
    /// <remarks>
    /// This class implements the Factory Method by returning a
    /// <see cref="PushNotifier"/> object.
    /// </remarks>
    public class PushNotifierFactory : NotifierFactory
    {
        /// <summary>
        /// Creates and returns a new <see cref="PushNotifier"/>.
        /// </summary>
        /// <returns>
        /// A new instance of <see cref="PushNotifier"/>.
        /// </returns>
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
