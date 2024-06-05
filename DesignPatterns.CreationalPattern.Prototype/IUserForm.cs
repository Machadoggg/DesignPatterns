namespace DesignPatterns.CreationalPattern.Prototype
{
    public interface IUserForm : ICloneable
    {
        string UserName { get; set; }
        string Email { get; set; }

        void ShowDetails();
    }
}
