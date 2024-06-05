using DesignPatterns.CreationalPattern.Builder;

var builder = new HouseBuilder();
var director = new Director(builder);

// Build a house with: Garage, SwimPool and Garden
director.Construct(hasGarage: true, hasSwimPool: true, hasStatues: false, hasGarden: true);
House house = builder.GetHouse();

house.ShowDetails();