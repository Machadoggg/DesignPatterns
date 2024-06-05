

// Create a store for Modern furniture
using DesignPatterns.CreationalPattern.AbstractFactory;
IFurnitureFactory modernFactory = new ModernFurnitureFactory();
FurnitureStore modernStore = new FurnitureStore(modernFactory);
Console.WriteLine("1. Procesing order for MODERN furniture: ");
modernStore.ProcessOrder();


// Create a store for Modern furniture
IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
FurnitureStore victorianStore = new FurnitureStore(victorianFactory);
Console.WriteLine("\n2. Procesing order for VICTORIAN furniture: ");
victorianStore.ProcessOrder();


// Create a store for Art Deco furniture
IFurnitureFactory artDecoFactory = new ArtDecoFurnitureFactory();
FurnitureStore artDecoStore = new FurnitureStore(artDecoFactory);
Console.WriteLine("\n3. Processing order for ART DECO furniture:");
artDecoStore.ProcessOrder();
