namespace InterpreterPattern
{
    // TerminalExpression: biểu thức hằng hoặc biến
    public class LiteralExpression : IExpression
    {
        private bool _value;

        public LiteralExpression(bool value)
        {
            _value = value;
        }

        public bool Interpret(Context context)
        {
            return _value;
        }
    }
}
