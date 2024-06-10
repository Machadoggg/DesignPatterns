namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class CarFlyweight
    {
        public string Company { get; } = default!;
        public string Model { get; } = default!;
        public string Color { get; set; } = default!;

        public CarFlyweight(string company, string model, string color)
        {
            Company = company;
            Model = model;
            Color = color;
        }


        public string GetSharedState()
        {
            return $"{{\"Company\":\"{Company}\",\"Model\":\"{Model}\",\"Color\":\"{Color}\"}}";
        }

        public void Display(string owner, string number)
        {
            Console.WriteLine($"\tFlyweight: Displaying shared {GetSharedState()} and unique {{\"Owner\":\"{owner}\",\"Number\":\"{number}\",\"Company\":\"{Company}\",\"Model\":\"{Model}\",\"Color\":\"{Color}\"}} state.");
        }


    }
}
