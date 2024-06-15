namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public class Director : User
    {
        public override void HandleRequest(SalesRequest request)
        {
            if (request.RequestType == "Large Sale")
            {
                Console.WriteLine($"{this.GetType().Name} handled request: {request.Description}");
            }
            else
            {
                Console.WriteLine($"Request: {request.Description} requires further evaluation.");
            }
        }
    }
}
