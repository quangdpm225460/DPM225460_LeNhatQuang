namespace Decorator.Example
{
    /// <summary>
    /// ConcreteComponent - SMS
    /// </summary>
    public class SMSNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine("📱 Sending SMS: " + message);
        }
    }
}

