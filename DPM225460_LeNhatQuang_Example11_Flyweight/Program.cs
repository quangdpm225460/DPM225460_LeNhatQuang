using FlyweightDemo;
using System;
using System.Collections.Generic;

namespace DPM225460_LeNhatQuang_Example11_Flyweight
{

    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            forest.PlantTree(10, 20, "Oak", "Green", "Rough");
            forest.PlantTree(15, 25, "Oak", "Green", "Rough");
            forest.PlantTree(30, 40, "Pine", "Dark Green", "Smooth");

            forest.Draw();
        }
    }
}
