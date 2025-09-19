namespace Decorator.Example
{
    /// <summary>
    /// ConcreteDecorator - ghi log
    /// </summary>
    public class LoggedNotification : NotificationDecorator
    {
        public LoggedNotification(Notification notification) : base(notification) { }

        public override void Send(string message)
        {
            Console.WriteLine("[LOG] Sending message: " + message);
            base.Send(message);
        }
    }
}

