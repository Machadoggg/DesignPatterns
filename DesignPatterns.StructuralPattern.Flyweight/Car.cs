namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class Car
    {
        public string Owner { get; }
        public string Number { get; }

        private CarFlyweight flyweight;

        public Car(string owner, string number, CarFlyweight flyweight)
        {
            Owner = owner;
            Number = number;
            this.flyweight = flyweight;
        }

        public void Display()
        {
            flyweight.Display(Owner, Number);
        }
    }
}
