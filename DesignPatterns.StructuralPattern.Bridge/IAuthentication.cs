namespace DesignPatterns.StructuralPattern.Bridge
{
    public interface IAuthentication
    {
        bool Authenticate(string username, string credential);
    }
}
