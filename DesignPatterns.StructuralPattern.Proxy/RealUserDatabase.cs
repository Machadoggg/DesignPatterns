namespace DesignPatterns.StructuralPattern.Proxy
{
    public class RealUserDatabase : IUserDatabase
    {
        public string GetUserData(int userId)
        {
            // Simulation of an expensive database call
            Console.WriteLine($"Fetching data for user {userId} from the real database.");
            return $"User data for user {userId}";
        }
    }
}
