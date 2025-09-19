namespace Decorator.Example
{
    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class NotificationDecorator : Notification
    {
        protected Notification notification;

        public NotificationDecorator(Notification notification)
        {
            this.notification = notification;
        }

        public override void Send(string message)
        {
            notification.Send(message);
        }
    }
}

