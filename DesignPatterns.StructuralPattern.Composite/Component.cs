namespace DesignPatterns.StructuralPattern.Composite
{
    public abstract class Component
    {
        public string Name { get; set; }


        protected Component(string name)
        {
            Name = name;
        }

        public abstract void Show(int depth);

    }
}
