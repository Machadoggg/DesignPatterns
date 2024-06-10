namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class CarFlyweightFactory
    {
        private Dictionary<string, CarFlyweight> flyweights = new Dictionary<string, CarFlyweight>();


        public CarFlyweight GetFlyweight(string company, string model, string color) 
        {
            string key = $"{company}_{model}_{color}";

            if (!flyweights.ContainsKey(key) ) 
            {
                flyweights[key] = new CarFlyweight(company, model, color);
            }
            return flyweights[key];
        }
    }
}
