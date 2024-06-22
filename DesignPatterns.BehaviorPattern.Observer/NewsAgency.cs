namespace DesignPatterns.BehaviorPattern.Observer
{
    public class NewsAgency : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string latestNews;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(latestNews);
            }
        }

        public void AddNews(string news)
        {
            latestNews = news;
            Notify();
        }

    }
}
