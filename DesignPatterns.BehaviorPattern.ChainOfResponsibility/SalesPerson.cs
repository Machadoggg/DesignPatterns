namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public class SalesPerson : User
    {
        public override void HandleRequest(SalesRequest request)
        {
            if (request.RequestType == "Small Sale")
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
