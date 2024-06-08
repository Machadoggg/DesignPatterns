namespace DesignPatterns.StructuralPattern.Bridge
{
    public class AdminUser : User
    {
        private string username;

        public AdminUser(string username, IAuthentication authentication) : base(authentication)
        {
            this.username = username;
        }

        public override void Login(string credential)
        {
            if (_authentication.Authenticate(username, credential)) 
            {
                Console.WriteLine($"Admin user {username} logged in successfully.");
            }
        }
    }
}
