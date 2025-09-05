using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreators
{
    /// <summary>
    /// A concrete factory that creates <see cref="EmailNotifier"/> instances.
    /// </summary>
    /// <remarks>
    /// This class implements the Factory Method by returning an
    /// <see cref="EmailNotifier"/> object.
    /// </remarks>
    public class EmailNotifierFactory : NotifierFactory
    {
        /// <summary>
        /// Creates and returns a new <see cref="EmailNotifier"/>.
        /// </summary>
        /// <returns>
        /// A new instance of <see cref="EmailNotifier"/>.
        /// </returns>
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
