using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreators
{
    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
