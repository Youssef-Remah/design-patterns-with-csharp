using NotificationSystem.AbstractProduct;

namespace NotificationSystem.AbstractCreator
{
    /// <summary>
    /// Defines the abstract factory that declares the factory method
    /// for creating <see cref="INotifier"/> objects.
    /// </summary>
    /// <remarks>
    /// This class is part of the Factory Method design pattern.
    /// Subclasses will implement the <see cref="CreateNotifier"/> method
    /// to instantiate specific types of notifiers (concrete products).
    /// </remarks>
    public abstract class NotifierFactory
    {
        /// <summary>
        /// Factory method that creates and returns a new instance of an <see cref="INotifier"/>.
        /// </summary>
        /// <returns>
        /// An object that implements the <see cref="INotifier"/> interface.
        /// </returns>
        public abstract INotifier CreateNotifier();
    }
}
