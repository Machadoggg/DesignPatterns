namespace DesignPatterns.StructuralPattern.Facade
{
    public class CinemaFacade
    {
        private TicketSystem _ticketSystem;
        private MovieSystem _movieSystem;
        private SnackSystem _snackSystem;


        public CinemaFacade()
        {
            _ticketSystem = new TicketSystem();
            _movieSystem = new MovieSystem();
            _snackSystem = new SnackSystem();
        }

        public void WatchMovie(string movie, int seats, string snack)
        {
            _ticketSystem.SellTicket(movie, seats);
            _snackSystem.OrderSnack(snack);
            _movieSystem.PlayMovie(movie);
            Console.WriteLine($"Enjoy the movie: {movie} with your snack: {snack}");
        }


    }
}
