namespace InterpreterPattern
{
    // AbstractExpression
    public interface IExpression
    {
        bool Interpret(Context context);
    }
}
