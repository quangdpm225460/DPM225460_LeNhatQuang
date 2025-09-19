﻿namespace Command.Structural
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>

    public abstract class Command
    {
        protected Receiver receiver;

        // Constructor

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}