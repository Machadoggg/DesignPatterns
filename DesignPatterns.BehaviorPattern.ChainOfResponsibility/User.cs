namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public abstract class User
    {
        protected User successor;


        public void SetSuccessor(User successor)
        { 
            this.successor = successor;
        }

        public abstract void HandleRequest(SalesRequest request);
    }
}
