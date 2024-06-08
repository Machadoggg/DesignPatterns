namespace DesignPatterns.StructuralPattern.Bridge
{
    public class BiometricAuthentication : IAuthentication
    {
        public bool Authenticate(string username, string credential)
        {
            Console.WriteLine($"Authentication {username} with biometric system");
            return true;
        }
    }
}
