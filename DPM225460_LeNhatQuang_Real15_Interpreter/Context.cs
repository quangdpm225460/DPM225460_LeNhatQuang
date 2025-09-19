﻿
namespace Interpreter.RealWorld
{
    /// <summary>
    /// The 'Context' class
    /// </summary>

    public class Context
    {
        string input;
        int output;

        // Constructor

        public Context(string input)
        {
            this.input = input;
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}