using NotificationSystem.AbstractProduct;

namespace NotificationSystem.AbstractCreator
{
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
