namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public abstract class User
    {
        protected User _succesor;


        public void SetSuccesor(User succesor)
        { 
            this._succesor = succesor;
        }

        public abstract void HandleRequest(SalesRequest request);
    }
}
