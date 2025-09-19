using ChainOfResponsibilityDemo;
using System;

namespace DPM225460_LeNhatQuang_Example13_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo chuỗi xử lý
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler manager = new ManagerSupport();

            level1.SetNext(level2);
            level2.SetNext(manager);

            // Gửi yêu cầu
            Console.WriteLine("Customer: I forgot my password.");
            level1.HandleRequest("password reset");

            Console.WriteLine("\nCustomer: I need help installing software.");
            level1.HandleRequest("software install");

            Console.WriteLine("\nCustomer: I want a refund.");
            level1.HandleRequest("refund");

            Console.WriteLine("\nCustomer: Unknown issue.");
            level1.HandleRequest("unknown issue");

            Console.ReadKey();
        }
    }
}
