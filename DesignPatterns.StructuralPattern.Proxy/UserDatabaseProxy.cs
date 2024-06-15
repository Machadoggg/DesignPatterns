namespace DesignPatterns.StructuralPattern.Proxy
{
    public class UserDatabaseProxy : IUserDatabase
    {
        private RealUserDatabase _realUserDatabase;
        private Dictionary<int, string> _cache;

        public UserDatabaseProxy()
        {
            _realUserDatabase = new RealUserDatabase();
            _cache = new Dictionary<int, string>();
        }


        public string GetUserData(int userId)
        {
            if (_cache.ContainsKey(userId)) 
            {
                Console.WriteLine($"Returning cached data for user {userId}");
                return _cache[userId];
            }

            Console.WriteLine($"No cached data for user {userId}. Fetching from real database");
            string userData = _realUserDatabase.GetUserData(userId);
            _cache[userId] = userData;
            return userData;
        }
    }
}
