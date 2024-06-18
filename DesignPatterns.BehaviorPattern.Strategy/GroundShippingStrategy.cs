namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class GroundShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(OrderContext order)
        {
            return order.Weight * 0.5; // cost for weight for ground shipping 
        }
    }
}
