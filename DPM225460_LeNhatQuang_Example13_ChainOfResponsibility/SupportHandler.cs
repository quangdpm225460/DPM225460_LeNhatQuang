namespace ChainOfResponsibilityDemo
{
    // Handler
    abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNext(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(string issue);
    }
}
