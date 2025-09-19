﻿namespace Interpreter.Structural
{
    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>

    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}