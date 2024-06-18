

using DesignPatterns.BehaviorPattern.Strategy;

OrderContext order = new OrderContext { Weight = 10 };


// Ground shipping
order.ShippingStrategy = new GroundShippingStrategy();
Console.WriteLine($"Ground shipping cost: {order.CalculateShippingCost()}");


// Air shipping 
order.ShippingStrategy = new AirShippingStrategy();
Console.WriteLine($"Air shipping cost: {order.CalculateShippingCost()}");


// Sea shipping 
order.ShippingStrategy = new SeaShippingStrategy();
Console.WriteLine($"Sea shipping cost: {order.CalculateShippingCost()}");
