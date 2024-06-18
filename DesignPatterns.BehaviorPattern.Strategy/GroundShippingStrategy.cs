namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class GroundShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            return order.weight * 0.5; // cost for weight for ground shipping 
        }
    }
}
