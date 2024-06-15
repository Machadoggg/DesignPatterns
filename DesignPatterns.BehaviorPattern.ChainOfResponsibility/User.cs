namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public abstract class User
    {
        protected User successor;


        public void SetSuccesor(User successor)
        { 
            this.successor = successor;
        }

        public abstract void HandleRequest(SalesRequest request);
    }
}
