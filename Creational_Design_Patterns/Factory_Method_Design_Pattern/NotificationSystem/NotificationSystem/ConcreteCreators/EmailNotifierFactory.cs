using NotificationSystem.AbstractCreator;
using NotificationSystem.AbstractProduct;
using NotificationSystem.ConcreteProducts;

namespace NotificationSystem.ConcreteCreators
{
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
