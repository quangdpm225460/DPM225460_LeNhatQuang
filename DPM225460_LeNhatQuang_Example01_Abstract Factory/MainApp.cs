using System;

namespace DPM225460_LeNhatQuang_Example01_Abstract_Factory
{
    class MainApp
    {
        public static void Main()
        {
            // Abstract factory #1
            PhongBan phongBanHang = new PhongBanHang();
            Client client1 = new Client(phongBanHang);
            client1.Run();
            // Abstract factory #2
            PhongBan phongKyThuat = new PhongKyThuat();
            Client client2 = new Client(phongKyThuat);
            client2.Run();
            // Wait for user input
            Console.ReadKey();
        }
    }
}
