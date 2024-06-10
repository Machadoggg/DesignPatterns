namespace DesignPatterns.StructuralPattern.Decorator
{
    public class NotifierDecorator : INotifier
    {
        protected INotifier _notifier;

        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }


        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
