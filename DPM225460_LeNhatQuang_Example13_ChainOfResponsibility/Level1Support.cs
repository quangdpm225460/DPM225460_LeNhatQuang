namespace ChainOfResponsibilityDemo
{
    // ConcreteHandler 1: Level 1 Support
    class Level1Support : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "password reset")
            {
                Console.WriteLine("Level 1 Support: Resolved password reset issue.");
            }
            else if (nextHandler != null)
            {
                Console.WriteLine("Level 1 Support: Escalating issue...");
                nextHandler.HandleRequest(issue);
            }
        }
    }
}
