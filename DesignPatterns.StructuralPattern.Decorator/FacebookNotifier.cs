namespace DesignPatterns.StructuralPattern.Decorator
{
    public class FacebookNotifier : NotifierDecorator
    {
        public FacebookNotifier(INotifier notifier) : base(notifier)
        {
        }


        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Sending Facebook notification: {message}");
        }
    }
}
