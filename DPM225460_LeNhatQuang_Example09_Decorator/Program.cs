using Decorator.Example;
using System;

namespace DPM225460_LeNhatQuang_Example09_Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo notification gốc
            Notification email = new EmailNotification();
            Notification sms = new SMSNotification();

            // Hiển thị cơ bản
            email.Send("Hello from Email!");
            sms.Send("Hello from SMS!");

            Console.WriteLine("\n--- Thêm tính năng Decorator ---");

            // Gói thêm decorator: mã hóa và ghi log
            Notification secureEmail = new EncryptedNotification(new LoggedNotification(email));
            Notification secureSms = new EncryptedNotification(new LoggedNotification(sms));

            // Gửi sau khi trang bị decorator
            secureEmail.Send("Sensitive Email Data");
            secureSms.Send("Sensitive SMS Data");

            Console.ReadKey();
        }
    }
}

