namespace DesignPatterns.BehaviorPattern.Command
{
    public class RemoteControlInvoker
    {
        private ICommand _command;


        public void Setcommand(ICommand command)
        {
            _command = command;
        }

        public void PressButtn()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}
