namespace DesignPatterns.BehaviorPattern.Strategy
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(Order order);
    }
}
