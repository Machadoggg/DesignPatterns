namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class CarFlyweightFactory
    {


        private Dictionary<string, CarFlyweight> flyweights = new Dictionary<string, CarFlyweight>();

        public CarFlyweight GetFlyweight(string company, string model, string color)
        {
            string key = $"{company}_{model}_{color}";
            if (flyweights.ContainsKey(key))
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                flyweights[key] = new CarFlyweight(company, model, color);
            }
            return flyweights[key];
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"FlyweightFactory: I have {flyweights.Count} flyweights:");
            foreach (var key in flyweights.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}
