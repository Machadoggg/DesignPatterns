namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class AirShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(OrderContext order)
        {
            return order.Weight * 1.0; // Cost for weight for air shipping
        }
    }
}
