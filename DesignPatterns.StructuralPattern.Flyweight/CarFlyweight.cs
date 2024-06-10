namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class CarFlyweight
    {
        public CarFlyweight(string company, string model, string color)
        {
            Company = company;
            Model = model;
            Color = color;
        }

        public string Company { get; } = default!;
        public string Model { get; } = default!;
        public string Color { get; set; } = default!;

        public void Display(string owner, string number)
        {
            Console.WriteLine($"Car {number}: {Company} {Model} in {Color}, owned by {owner}");
        }


    }
}
