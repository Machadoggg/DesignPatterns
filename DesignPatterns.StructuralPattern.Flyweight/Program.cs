using DesignPatterns.StructuralPattern.Flyweight;


CarFlyweightFactory factory = new CarFlyweightFactory();

factory.GetFlyweight("Chevrolet", "Camaro2018", "pink");
factory.GetFlyweight("Mercedes Benz", "C300", "black");
factory.GetFlyweight("Mercedes Benz", "C500", "red");
factory.GetFlyweight("BMW", "M5", "red");
factory.GetFlyweight("BMW", "X6", "white");

factory.ListFlyweights();

Console.WriteLine("\nClient: Adding a car to database.");
CarFlyweight flyweight1 = factory.GetFlyweight("BMW", "M5", "red");
Car car1 = new Car("James Doe", "CL234IR", flyweight1);
car1.Display();

Console.WriteLine("\nClient: Adding a car to database.");
CarFlyweight flyweight2 = factory.GetFlyweight("BMW", "X1", "red");
Car car2 = new Car("James Doe", "CL234IR", flyweight2);
car2.Display();

factory.ListFlyweights();
