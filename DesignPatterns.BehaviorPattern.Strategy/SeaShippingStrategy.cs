namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class SeaShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(OrderContext order)
        {
            return order.Weight * 0.2; // Cost for weight for sea shipping
        }
    }
}
