namespace DesignPatterns.BehaviorPattern.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
