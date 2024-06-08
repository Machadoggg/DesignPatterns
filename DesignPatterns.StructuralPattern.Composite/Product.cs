
namespace DesignPatterns.StructuralPattern.Composite
{
    public class Product : Component
    {

        public Product(string name) : base(name) 
        {
            
        }


        public override void Show(int depth)
        {
            Console.WriteLine(new String(' ', depth) + Name);
        }
    }
}
