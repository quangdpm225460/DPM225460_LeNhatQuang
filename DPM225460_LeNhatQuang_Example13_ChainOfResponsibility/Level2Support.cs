namespace ChainOfResponsibilityDemo
{
    // ConcreteHandler 2: Level 2 Support
    class Level2Support : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "software install")
            {
                Console.WriteLine("Level 2 Support: Resolved software installation issue.");
            }
            else if (nextHandler != null)
            {
                Console.WriteLine("Level 2 Support: Escalating issue...");
                nextHandler.HandleRequest(issue);
            }
        }
    }
}
