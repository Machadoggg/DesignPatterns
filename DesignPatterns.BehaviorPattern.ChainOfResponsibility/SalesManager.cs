namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public class SalesManager : User
    {
        public override void HandleRequest(SalesRequest request)
        {
            if (request.RequestType == "Medium Sale")
            {
                Console.WriteLine($"{this.GetType().Name} handled request: {request.Description}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
