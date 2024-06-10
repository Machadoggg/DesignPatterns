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
                Console.WriteLine($"\tFlyweightFactory: Reusing existing flyweight [{company}].");
            }
            else
            {
                Console.WriteLine($"FlyweightFactory: Can't find a flyweight, creating new one [{company}].");
                flyweights[key] = new CarFlyweight(company, model, color);
            }
            return flyweights[key];
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"\tFlyweightFactory: I have [{flyweights.Count} flyweights]:");
            int count = 0;
            foreach (var key in flyweights.Keys)
            {
                count = count + 1;
                Console.WriteLine($"\t\t{count} - {key}");
            }
        }
    }
}
