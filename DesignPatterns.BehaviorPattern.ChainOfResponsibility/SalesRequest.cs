namespace DesignPatterns.BehaviorPattern.ChainOfResponsibility
{
    public class SalesRequest
    {
        
        public string RequestType { get; }
        public double Amount { get; }
        public string Description { get; }


        public SalesRequest(string requestType, double amount, string description)
        {
            RequestType = requestType;
            Amount = amount;
            Description = description;
        }



    }
}