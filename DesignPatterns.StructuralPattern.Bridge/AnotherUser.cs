namespace DesignPatterns.StructuralPattern.Bridge
{
    public class AnotherUser : User
    {
        private string username;

        public AnotherUser(string username, IAuthentication authentication) : base(authentication)
        {
            this.username = username;
        }

        public override void Login(string credential)
        {
            if (_authentication.Authenticate(username, credential))
            {
                Console.WriteLine($"AnotherUser user {username} logged in successfully.");
            }
        }
    }
}
