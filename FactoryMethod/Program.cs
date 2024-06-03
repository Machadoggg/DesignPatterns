

using FactoryMethod;

TransportFactory factory;

Random random = new Random();

int randomNumber = random.Next(1, 3);

if (randomNumber == 1)
{
    factory = new CarFactory();
    ITransport car = factory.CreateTransport();
    car.Deliver();
}

if (randomNumber == 2)
{
    factory = new BicycleFactory();
    ITransport bicycle = factory.CreateTransport();
    bicycle.Deliver();
}