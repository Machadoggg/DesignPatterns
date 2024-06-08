namespace DesignPatterns.StructuralPattern.Composite
{
    public class Box : Component
    {
        private List<Component> _components = new List<Component>();

        public Box(string name) : base(name) 
        {
            
        }



        public void Add(Component component)
        {
            _components.Add(component);
        }

        public void Remove(Component component)
        {
            _components.Remove(component);
        }


        public override void Show(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach (Component component in _components) 
            {
                component.Show(depth + 2);
            }
        }
    }
}
