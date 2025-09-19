using IteratorPattern;
using System;
using System.Collections.Generic;

namespace DPM225460_LeNhatQuang_Example16_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection students = new StudentCollection();
            students.Add("An");
            students.Add("Bình");
            students.Add("Chi");
            students.Add("Dung");

            IIterator<string> iterator = students.CreateIterator();

            Console.WriteLine("Danh sách sinh viên:");
            while (iterator.HasNext())
            {
                Console.WriteLine("- " + iterator.Next());
            }
        }
    }
}
