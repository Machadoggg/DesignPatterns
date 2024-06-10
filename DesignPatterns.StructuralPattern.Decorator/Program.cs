
// Create a basic notificator
using DesignPatterns.StructuralPattern.Decorator;

INotifier notifier = new BaseNotifier();



// Decorate with SMSNotifier, FacebookNotifier, SlackNotifier
notifier = new SMSNotifier(notifier);
notifier = new FacebookNotifier(notifier);
notifier = new SlackNotifier(notifier);


// Send notification
notifier.Send("Hello, world!");
