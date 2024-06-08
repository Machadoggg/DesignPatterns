namespace DesignPatterns.StructuralPattern.Bridge
{
    public abstract class User
    {
        protected IAuthentication _authentication;


        protected User(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public abstract void Login(string credential);
    }
}
