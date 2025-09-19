namespace CommandPattern
{
    // ConcreteCommand: bật TV
    public class TurnOnCommand : ICommand
    {
        private TV _tv;

        public TurnOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}
