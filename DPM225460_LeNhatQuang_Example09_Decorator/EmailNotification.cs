namespace Decorator.Example
{
    /// <summary>
    /// ConcreteComponent - Email
    /// </summary>
    public class EmailNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine("📧 Sending Email: " + message);
        }
    }
}

