namespace Decorator.Example
{
    /// <summary>
    /// ConcreteDecorator - mã hóa
    /// </summary>
    public class EncryptedNotification : NotificationDecorator
    {
        public EncryptedNotification(Notification notification) : base(notification) { }

        public override void Send(string message)
        {
            string encrypted = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
            Console.WriteLine("[ENCRYPT] Original: " + message);
            base.Send(encrypted);
        }
    }
}

