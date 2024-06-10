using DesignPatterns.StructuralPattern.Flyweight;

CarFlyweightFactory factory = new CarFlyweightFactory();

CarFlyweight bmwRed = factory.GetFlyweight("BMW", "X5", "Red");
CarFlyweight audiBlue = factory.GetFlyweight("Audi", "A4", "Blue");

Car car1 = new Car("John Doe", "1234", bmwRed);
Car car2 = new Car("Jane Smith", "5678", audiBlue);
Car car3 = new Car("Alice Johnson", "9101", bmwRed); // Compartido

car1.Display();
car2.Display();
car3.Display();
