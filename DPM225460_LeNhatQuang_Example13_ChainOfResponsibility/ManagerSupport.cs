namespace ChainOfResponsibilityDemo
{
    // ConcreteHandler 3: Manager
    class ManagerSupport : SupportHandler
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "refund")
            {
                Console.WriteLine("Manager: Approved refund request.");
            }
            else
            {
                Console.WriteLine("Manager: Issue could not be resolved.");
            }
        }
    }
}
