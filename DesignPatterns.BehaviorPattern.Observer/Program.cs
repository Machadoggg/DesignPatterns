

// Create agency news
using DesignPatterns.BehaviorPattern.Observer;

NewsAgency newsAgency = new NewsAgency();

// Create subscriptors
Subscriber subscriber1 = new Subscriber("Subscriber 1");
Subscriber subscriber2 = new Subscriber("Subscriber 2");

// Add subscriptors to agency news
newsAgency.Attach(subscriber1);
newsAgency.Attach(subscriber2);

// Add news
newsAgency.AddNews("Breaking News: New Observer Pattern Example Released!");

// Delete a subscriptor
newsAgency.Detach(subscriber1);

// Add more newss
newsAgency.AddNews("More News: Observer Pattern Example Updated!");
