

using FactoryMethod;

TransportFactory factory;

// create car
factory = new CarFactory();
ITransport car = factory.CreateTransport();
car.Deliver();

// create bicycle
factory = new BicycleFactory();
ITransport bicycle = factory.CreateTransport();
bicycle.Deliver();