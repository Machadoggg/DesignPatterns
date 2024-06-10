namespace DesignPatterns.StructuralPattern.Decorator
{
    public class BaseNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending basic notification: {message}");
        }
    }
}
