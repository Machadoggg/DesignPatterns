namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class OrderContext
    {
        public double Weight { get; set; }
        public IShippingStrategy ShippingStrategy { get; set; }


        public double CalculateShippingCost()
        {
            return ShippingStrategy.CalculateShippingCost(this);
        }
    }
}
