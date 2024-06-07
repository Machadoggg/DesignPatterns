namespace DesignPatterns.StructuralPattern.Facade
{
    public class TicketSystem
    {
        public void SellTicket(string movie, int seats)
        {
            Console.WriteLine($"Selling {seats} movie tickets: {movie}");
        }
    }
}
