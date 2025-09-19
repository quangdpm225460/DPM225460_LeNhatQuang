namespace CommandPattern
{
    // ConcreteCommand: tắt TV
    public class TurnOffCommand : ICommand
    {
        private TV _tv;

        public TurnOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOff();
        }
    }
}
