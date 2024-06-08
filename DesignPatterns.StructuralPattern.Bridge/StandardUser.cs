namespace DesignPatterns.StructuralPattern.Bridge
{
    public class StandardUser : User
    {
        private string username;

        public StandardUser(string username, IAuthentication authentication) : base(authentication) 
        {
            this.username = username;
        }

        public override void Login(string credential)
        {
            if (_authentication.Authenticate(username, credential)) 
            {
                Console.WriteLine($"Standard user {username} logged in successfully.");
            }
        }
    }
}
