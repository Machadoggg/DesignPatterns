
using DesignPatterns.StructuralPattern.Composite;


// Create indiviadual products
Product product1 = new Product("Product 1");
Product product2 = new Product("Product 2");



// Create a box and add products
Box box1 = new Box("Small Box");
box1.Add(product1);
box1.Add(product2);



// Create a larger box and add a smaller box and a product
Box box2 = new Box("Big Box");
box2.Add(box1);
box2.Add(new Product("Product 3"));


// Show the structure
box2.Show(1);

