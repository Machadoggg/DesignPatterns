namespace DesignPatterns.BehaviorPattern.Strategy
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(OrderContext order);
    }
}
