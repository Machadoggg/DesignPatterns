namespace DesignPatterns.StructuralPattern.Bridge
{
    public class TokenAuthentication : IAuthentication
    {
        public bool Authenticate(string username, string credential)
        {
            Console.WriteLine($"Authentication {username} with token");
            return true;
        }
    }
}
