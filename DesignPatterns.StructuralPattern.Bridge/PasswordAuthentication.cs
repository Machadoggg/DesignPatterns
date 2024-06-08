namespace DesignPatterns.StructuralPattern.Bridge
{
    public class PasswordAuthentication : IAuthentication
    {
        public bool Authenticate(string username, string credential)
        {
            Console.WriteLine($"Authenticating {username} with password");
            return true;
        }
    }
}
